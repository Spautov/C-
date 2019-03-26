using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Drawing;
using DALPanels.Model;
using System.Globalization;

namespace XMLParserTo2D
{
    public class ParserXMLTo2D
    {
        private XDocument _xdoc;

        private Bitmap _image;

        private Panel _rootPanel;

        public ParserXMLTo2D(string filename)
        {
            try
            {
                _xdoc = XDocument.Load(filename);
            }
            catch (Exception)
            {
                string message = "It was not succeeded to load the file: " + filename;
                throw new Exception(message);
            }
        }

        private void InitImage()
        {
            SizeF imaSizeF = new SizeF(0, 0);
            _rootPanel.GetMaxSize(ref imaSizeF);
            Size ImaSize = imaSizeF.ToSize();
            _image = new Bitmap((int)ImaSize.Width+10, (int)ImaSize.Height+10);
        }

        public void ToDo()
        {
            ParseByXML();
            InitImage();
            Graphics gr = Graphics.FromImage(_image);

            if (_rootPanel != null && gr != null)
            {
                gr.Clear(Color.White);
                _rootPanel.Draw(gr);
            }
            _image.Save("OutFileFromXML.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void ParseByXML()
        {
            var rootElem = _xdoc.Root;
            float rootX = 0.0F;
            float rootY = 0.0F;
            //int originalDocumentHeight = 0;
            //int originalDocumentWidth = 0;

            string rootPanelName;
            float rootPanelWidth = 0.0F;
            float rootPanelHeight = 0.0F;
            float rootPanelHingeOffset = 0;
            byte rootPanelAttachedToSide = 0;

            rootX = float.Parse(rootElem.Attribute("rootX").Value, NumberStyles.Number, new CultureInfo("en-GB"));
            rootY = float.Parse(rootElem.Attribute("rootY").Value, NumberStyles.Number, new CultureInfo("en-GB"));
            //originalDocumentHeight = Int32.Parse(rootElem.Attribute("originalDocumentHeight").Value);
            //originalDocumentWidth = Int32.Parse(rootElem.Attribute("originalDocumentWidth").Value);

            var XElemPlanesRoot = rootElem.Element("panels").Element("item");
            rootPanelName = XElemPlanesRoot.Attribute("panelName").Value;
            rootPanelWidth = float.Parse(XElemPlanesRoot.Attribute("panelWidth").Value, NumberStyles.Number, new CultureInfo("en-GB"));
            rootPanelHeight = float.Parse(XElemPlanesRoot.Attribute("panelHeight").Value, NumberStyles.Number, new CultureInfo("en-GB"));
            rootPanelHingeOffset = float.Parse(XElemPlanesRoot.Attribute("hingeOffset").Value, NumberStyles.Number, new CultureInfo("en-GB"));
            rootPanelAttachedToSide = byte.Parse(XElemPlanesRoot.Attribute("attachedToSide").Value);

            _rootPanel = new Panel(rootPanelName,
                new SizeF(rootPanelWidth, rootPanelHeight),
                rootPanelHingeOffset,
                rootPanelAttachedToSide,
                new PointF(rootX, rootY),
                Rotation.zero);

            var AttachedItem = XElemPlanesRoot.Element("attachedPanels").Elements("item");
            if (AttachedItem.Count() > 0)
            {
                _rootPanel.AttachedPanels = GetPanelItem(AttachedItem, _rootPanel);
            };
            
        }

        private List<Panel> GetPanelItem(IEnumerable<XElement> XCollect, Panel prtPanel)
        {
            List<Panel> returnList = new List<Panel>();

            string PanelName;
            float PanelWidth = 0.0F;
            float PanelHeight = 0.0F;
            float PanelHingeOffset = 0;
            byte PanelAttachedToSide = 0;
            PointF point;

            foreach (var item in XCollect)
            {                
                PanelName = item.Attribute("panelName").Value;
                PanelWidth = float.Parse(item.Attribute("panelWidth").Value, NumberStyles.Number, new CultureInfo("en-GB"));
                PanelHeight = float.Parse(item.Attribute("panelHeight").Value, NumberStyles.Number, new CultureInfo("en-GB"));
                PanelHingeOffset = float.Parse(item.Attribute("hingeOffset").Value, NumberStyles.Number, new CultureInfo("en-GB"));
                PanelAttachedToSide = (byte)Int32.Parse(item.Attribute("attachedToSide").Value);
                point = prtPanel.GetMidlePoint(PanelAttachedToSide);

                Panel tmpPanal = new Panel(
                    PanelName,
                    new SizeF(PanelWidth, PanelHeight),
                    PanelHingeOffset,
                    PanelAttachedToSide,
                    point, 
                    prtPanel.RotationAngle
                    );
                var AttachedItem = item.Element("attachedPanels").Elements("item");
                if (AttachedItem.Count() > 0)
                {
                    tmpPanal.AttachedPanels = GetPanelItem(AttachedItem, tmpPanal);
                }
                returnList.Add(tmpPanal);
            }
            return returnList;
        }
    }
}
