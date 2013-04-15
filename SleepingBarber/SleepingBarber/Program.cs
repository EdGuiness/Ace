using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingBarber
{
    /// <summary>
    /// ALERT: UNFINISHED AND INCORRECT CODE BELOW - DO NOT USE 
    /// </summary>
    class Shop
    {
        static Random random = new Random();

        static ConcurrentQueue<Customer> waitingRoom = new ConcurrentQueue<Customer>();
        static object lockToChangeState = new object();

        static Customer seatedCustomer;

        const int WAITING_ROOM_SEATS = 5;

        static Barber barber;

        static void Main(string[] args)
        {
            TConsole.WriteLine("start...");
            barber = new Barber();

            Task.Factory.StartNew(() =>
            {
                TConsole.WriteLine("starting");
                barber.DoWork();
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                    if (random.Next(1000) < 10)
                    {
                        Customer c = new Customer();
                        c.LookAtBarber();
                    }

            });

            Console.ReadKey();
            Console.ReadKey();
        }

        static void GotoWaitingRoom(Customer c)
        {
            TConsole.WriteLine(string.Format("Customer {0} goes to waiting room", c.Name));
            TConsole.WriteLine(string.Format("Customer finds {0} people waiting", waitingRoom.Count)); 

            if (waitingRoom.Count < WAITING_ROOM_SEATS)
            {
                TConsole.WriteLine(string.Format("Customer {0} sits in waiting room", c.Name));
                waitingRoom.Enqueue(c);
            }
            else
            {
                TConsole.WriteLine(string.Format("Waiting room is full. Customer {0} leaves.", c.Name));
            }
        }

        class Barber
        {
            public bool Sleeping { get; set; }
            public bool CuttingHair { get { return seatedCustomer != null; } }

            public Barber()
            {
                Sleeping = false;
            }

            public void CheckWaitingRoom()
            {
                TConsole.WriteLine("Barber checks the waiting room...");
                Customer activeCustomer = null;

                lock (lockToChangeState)
                    if (waitingRoom.Count > 0)
                    {
                        if (!waitingRoom.TryDequeue(out activeCustomer))
                        {
                            Debug.Assert(false, "Unable to dequeue customer!");
                            return;
                        }
                    }
                if (activeCustomer != null)
                {
                    Haircut(activeCustomer);
                }

                else
                {
                    TConsole.WriteLine("No one waiting. Barber goes to sleep.");
                    lock (lockToChangeState)
                        Sleeping = true;
                }
            }

            public void Haircut(Customer customer)
            {
                lock (lockToChangeState)
                    seatedCustomer = customer;

                TConsole.WriteLine(string.Format("Giving customer {0} a haircut", seatedCustomer.Name));

                // Pause for the haircut
                System.Threading.Thread.Sleep(random.Next(5000));

                lock (lockToChangeState)
                {
                    TConsole.WriteLine(string.Format("Barber finishes haircut, customer {0} leaves", seatedCustomer.Name));
                    seatedCustomer = null;
                }
                    CheckWaitingRoom();
            }

            public void Wake(Customer customer)
            {
                if (!Sleeping)
                    throw new NotSleepingException();

                lock (lockToChangeState)
                {
                    TConsole.WriteLine(string.Format("Barber woken by customer {0}", customer.Name));

                    Sleeping = false;
                    seatedCustomer = customer;
                }
                Haircut(seatedCustomer);
            }

            public void Sleep()
            {
                lock (lockToChangeState)
                    if (!Sleeping)
                    {
                        Sleeping = true;
                        TConsole.WriteLine("Barber goes to sleep...");
                    }
            }

            public void DoWork()
            {
                while (true)
                {
                    lock (lockToChangeState)
                        if (CuttingHair || Sleeping)
                            continue;

                    CheckWaitingRoom();
                }
            }
        }
        class Customer
        {
            public string Name { get; set; }
            public Customer()
            {
                Name = RandomMaleName.Next();

                TConsole.WriteLine(string.Format("Customer {0} arrives.", Name));
            }

            public void LookAtBarber()
            {
                lock (lockToChangeState)
                {
                    TConsole.WriteLine(string.Format("Customer {0} looks at barber", Name));
                    if (barber.Sleeping)
                        barber.Wake(this);
                    else
                        GotoWaitingRoom(this);
                }
            }
        }
    }

}
