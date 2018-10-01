using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace Task_1
{
    public static class Terminal
    {
        public static void ShowMainMenu(ref Bank bank)
        {
            int select;
            Console.WriteLine("Приветствуем Вас в нашей системе Клиент-Банк");

            while (true)
            {
                try
                {
                    Console.WriteLine("Главное меню:");
                    Console.WriteLine("Открыть счет введите - 1");
                    Console.WriteLine("Войти в личный кабинет введите - 2");
                    Console.WriteLine("Выход введите - 0");

                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            {
                                OpenAccount(ref bank);
                            }
                            break;
                        case 2:
                            {
                                SingIn(bank);
                            }
                            break;
                        case 0:
                            {
                                Environment.Exit(0);
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректные данные");
                }

            }
        }



        private static void SingIn(Bank bank)
        {
            string login;
            string password;
            int select;
            while (true)
            {
                Console.WriteLine("Вход в личный кабинет:");
                Console.WriteLine("Для продолжения введите - 1");
                Console.WriteLine("Для выхода в Главное меню введите - 2");
                Console.WriteLine("Для выхода введите - 0");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    if (select == 0)
                    {
                        Environment.Exit(0);
                    }
                    if (select == 2)
                    {
                        return;
                    }
                    if (select == 1)
                    {
                        Console.WriteLine("Введите логин");
                        login = Console.ReadLine();
                        Console.WriteLine("Введите пароль");
                        password = Console.ReadLine();
                        int numClient = bank.LogIn(login, password);
                        if (numClient==-1)
                        {
                            Console.WriteLine("Вы ввели неверный логин или пароль");
                            continue;
                        }
                        OperationsInBank(bank, numClient);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректные данные");
                }
            }


        }
       

        private static void OperationsInBank(Bank bank, int numClient)
        {
            int select;
            while (true)
            {
                Console.WriteLine("Личный кабинет пользователя: {0} {1}", bank.clients[numClient].FirstName, bank.clients[numClient].LastName);
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Вывод баланса на экран");
                Console.WriteLine("2 - Пополнение счета");
                Console.WriteLine("3 - Снятие денег со счета");
                Console.WriteLine("4 - Активировать резервный счет");
                Console.WriteLine("5 - Возврат в предыдушее меню");
                Console.WriteLine("0 - Выход");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            {
                                Console.WriteLine("Баланс вашего счета составляет {0:f2} руб.",
                                    bank.clients[numClient].SeeBalance(SelectAccount()));
                            }
                            break;
                        case 2:
                            {
                                int num = SelectAccount();
                                int summ;
                                Console.WriteLine("Введите сумму для пополнения:");
                                try
                                {
                                    summ = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    throw new Exception("Введена некорректная сумма");
                                }
                                bank.clients[numClient].Recharge(summ ,num);
                                Console.WriteLine("Баланс вашего счета составляет {0:f2} руб.",
                                    bank.clients[numClient].SeeBalance(num));
                            }
                            break;
                        case 3:
                            {
                                int num = SelectAccount();
                                int summ;
                                Console.WriteLine("Введите сумму для снятия:");
                                try
                                {
                                    summ = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    throw new Exception("Введена некорректная сумма");
                                }
                                bank.clients[numClient].ReceiveMoney(summ, num);
                                Console.WriteLine("Баланс вашего счета составляет {0:f2} руб.",
                                    bank.clients[numClient].SeeBalance(num));

                            }
                            break;
                        case 4:
                            {
                                bank.clients[numClient].ActivateReseveAccount();
                                Console.WriteLine("Ваш резервный счет активирован");
                            }
                            break;
                        case 5:
                            {
                                return;
                            }
                        case 0:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Вы ввели некорректные данные");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
      
        public static int SelectAccount()
        {
            int select = 0;
            bool continСycle = true;
            while (continСycle)
            {
                Console.WriteLine("Выберите счет:");
                Console.WriteLine("0 - основной");
                Console.WriteLine("1 - резервный");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    if (select<0 || select>1)
                    {
                        throw new Exception();
                    }
                    continСycle = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректные данные");
                    continСycle = true;
                }
            }
            return select;
        }


        public static void OpenAccount(ref Bank bank)
        {
            string firstName;
            string lastName;
            string login;
            string password;
            int passportNumber;
            bool continСycle = true;
            int select;
            while (continСycle)
            {
                Console.WriteLine("Открытие лицевого счета:");
                Console.WriteLine("Для продолжения введите - 1");
                Console.WriteLine("Для выхода в Главное меню введите - 2");
                Console.WriteLine("Для выхода введите - 0");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    if (select == 0)
                    {
                        Environment.Exit(0);
                    }
                    if (select == 2)
                    {
                        return;
                    }
                    if (select == 1)
                    {
                        try
                        {
                            Console.WriteLine("Введите имя:");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Введите фамилию:");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Введите номер паспорта");
                            passportNumber = Convert.ToInt32(Console.ReadLine());
                            while (true)
                            {
                                Console.WriteLine("Введите логин");
                                login = Console.ReadLine();
                                if (BankSecurity.IsUniquenessLogin(login, bank))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Такой логин уже зарегистрирован, , попробуйте еще раз");
                                }
                            }


                            while (true)
                            {
                                Console.WriteLine("Введите пароль");
                                password = Console.ReadLine();
                                if (BankSecurity.IsReliablePassword(password))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Пароль не является надежным, попробуйте еще раз");
                                }
                            }
                            bank.AddClient(firstName, lastName, login, password, passportNumber);
                            Console.WriteLine("Уважаемый(-я) {0} {1} на ваше имя открыт счет №{2}",
                                bank.clients[bank.CountClient - 1].FirstName,
                                bank.clients[bank.CountClient - 1].LastName,
                                bank.clients[bank.CountClient - 1].SettlementAccount.Number);
                            Console.WriteLine("За снятие наличных денег банк снимает {0}% от суммы снятия",
                                bank.clients[bank.CountClient - 1].SettlementAccount.Percent);
                            Console.WriteLine("Ваш логин: {0}", bank.clients[bank.CountClient - 1].Login);
                            Console.WriteLine("Ваш пароль: {0}", bank.clients[bank.CountClient - 1].Password);
                            continСycle = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            continСycle = true;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректные данные");
                    continСycle = true;
                }

            }
        }
    }
}
