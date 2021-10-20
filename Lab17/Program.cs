using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>();
            bank1.GetInfo(1486, 108396.9, "Пугачев Владимир Григорьевич");
            bank1.ShowInfo();

            Bank<string> bank2 = new Bank<string>();
            bank2.GetInfo("0313", 23018456, "Шутович Андрей Станиславович");
            bank2.ShowInfo();

            Console.ReadKey();
        }
    }

    class Bank<T>
    {
        private T account;
        private double balance;
        private string name;
        

        public void GetInfo(T account, double balance, string name)
        {
            this.account = account;
            this.balance = balance;
            this.name = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Номер счета: {account}\nБаланс: {balance}\nФИО: {name}") ;
        }
    }
}
