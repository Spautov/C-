using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALPanels.Model
{
    public enum Rotation
    {
        zero = 0,
        ninety = 90,
        hundred_eighty = 180,
        two_hundred_seventy = 270
    }

    public class Panel
    {
        private PointF[] _point;

        private SizeF _size;

        private Rotation _angle;

        private string _panelName;

        private float _hingeOffset;

        private PointF _pointStart;

        private byte _attachedToSide;

        private List<Panel> _attachedPanels;

        public Panel(string name,
                    SizeF size,
                    float hingeOffset,
                    byte attachedToSide,
                    PointF pointStart,
                    Rotation parentRotationAngle)
        {
            _point = new PointF[4];
            _size = size;
            _attachedPanels = new List<Panel>();

            _hingeOffset = hingeOffset;
            if (attachedToSide < 0 || attachedToSide > 3)
            {
                throw new Exception();
            }
            _attachedToSide = attachedToSide;
            _panelName = name;

            if (name == "root panel")
            {
                _angle = Rotation.zero;
                _pointStart = pointStart;
                InitSideZero();
            }
            else
            {
                InitRotationAngle(parentRotationAngle);

                if (_angle == Rotation.zero)
                {
                    _pointStart = new PointF(pointStart.X + _hingeOffset, pointStart.Y);
                    InitSideZero();
                }
                else if (_angle == Rotation.ninety)
                {
                    _pointStart = new PointF(pointStart.X, pointStart.Y - _hingeOffset);
                    InitSideNinety();
                }
                else if (_angle == Rotation.hundred_eighty)
                {
                    _pointStart = new PointF(pointStart.X - _hingeOffset, pointStart.Y);
                    InitSideHundredEighty();
                }
                else if (_angle == Rotation.two_hundred_seventy)
                {
                    _pointStart = new PointF(pointStart.X, pointStart.Y + _hingeOffset);
                    InitSideTwoHundredSeventy();
                }
            }
        }

        private void InitSideZero()
        {
            _point[0] = new PointF(_pointStart.X - 0.5F * _size.Width, _pointStart.Y);
            _point[1] = new PointF(_pointStart.X + 0.5F * _size.Width, _pointStart.Y);
            _point[2] = new PointF(_pointStart.X + 0.5F * _size.Width, _pointStart.Y - _size.Height);
            _point[3] = new PointF(_pointStart.X - 0.5F * _size.Width, _pointStart.Y - _size.Height);
        }

        private void InitSideNinety()
        {
            _point[0] = new PointF(_pointStart.X, _pointStart.Y + 0.5F * _size.Width);
            _point[1] = new PointF(_pointStart.X, _pointStart.Y - 0.5F * _size.Width);
            _point[2] = new PointF(_pointStart.X - _size.Height, _pointStart.Y - 0.5F * _size.Width);
            _point[3] = new PointF(_pointStart.X - _size.Height, _pointStart.Y + 0.5F * _size.Width);
        }

        private void InitSideHundredEighty()
        {
            _point[0] = new PointF(_pointStart.X + 0.5F * _size.Width, _pointStart.Y);
            _point[1] = new PointF(_pointStart.X - 0.5F * _size.Width, _pointStart.Y);
            _point[2] = new PointF(_pointStart.X - 0.5F * _size.Width, _pointStart.Y + _size.Height);
            _point[3] = new PointF(_pointStart.X + 0.5F * _size.Width, _pointStart.Y + _size.Height);
        }

        private void InitSideTwoHundredSeventy()
        {
            _point[0] = new PointF(_pointStart.X, _pointStart.Y - 0.5F * _size.Width);
            _point[1] = new PointF(_pointStart.X, _pointStart.Y + 0.5F * _size.Width);
            _point[2] = new PointF(_pointStart.X + _size.Height, _pointStart.Y + 0.5F * _size.Width);
            _point[3] = new PointF(_pointStart.X + _size.Height, _pointStart.Y - 0.5F * _size.Width);
        }

        private void InitRotationAngle(Rotation parentAngle)
        {
            int angle = 0;

            if (_attachedToSide == 1)
            {
                angle = (int)parentAngle + 270;
            }
            else if (_attachedToSide == 2)
            {
                angle = (int)parentAngle;
            }
            else if (_attachedToSide == 3)
            {
                angle = (int)parentAngle + 90;
            }
            else if (_attachedToSide == 0)
            {
                angle = (int)parentAngle + 180;
            }

            if (angle >= 360)
            {
                angle -= 360;
            }
            _angle = (Rotation)angle;
        }

        public PointF GetMidlePoint(int i)
        {
            switch (i)
            {
                case 0:
                    return new PointF((_point[0].X + _point[1].X) / 2, (_point[0].Y + _point[1].Y) / 2);
                case 1:
                    return new PointF((_point[1].X + _point[2].X) / 2, (_point[1].Y + _point[2].Y) / 2);
                case 2:
                    return new PointF((_point[2].X + _point[3].X) / 2, (_point[2].Y + _point[3].Y) / 2);
                case 3:
                    return new PointF((_point[3].X + _point[0].X) / 2, (_point[3].Y + _point[0].Y) / 2);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void GetMaxSize(ref SizeF resoltSise)
        {
            if (resoltSise != null)
            {
                foreach (var poin in _point)
                {
                    if (resoltSise.Width < poin.X)
                    {
                        resoltSise.Width = poin.X;
                    }
                    if (resoltSise.Height < poin.Y)
                    {
                        resoltSise.Height = poin.Y;
                    }
                }
                foreach (var panl in _attachedPanels)
                {
                    panl.GetMaxSize(ref resoltSise);
                }
            }
            else throw new NullReferenceException();
        }

        
        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black,3);
            
            graphics.DrawPolygon(pen, _point);
            foreach (var panl in _attachedPanels)
            {
                panl.Draw(graphics);
            }
        }



        public List<Panel> AttachedPanels
        {
            get
            {
                return this._attachedPanels;
            }
            set
            {
                this._attachedPanels = value;
            }
        }

        public string PanelName
        {
            get
            {
                return this._panelName;
            }
        }

        public Rotation RotationAngle
        {
            get
            {
                return this._angle;
            }
        }
    }
}
