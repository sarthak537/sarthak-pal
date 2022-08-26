using System;
class Address
{
    private int houseNo;
    private string houseName;
    private int pinCod;
    public int HouseNo
    {
        set
        {
            houseNo = value;
        }
        get
        {
            return houseNo;

        }
    
    }
    public string HouseName
    {
        set
        {
             houseName=value;
        }
        get
        {
            return houseName;
        }
    }
    public int tPinCod
    {
        set
        {
            pinCod = value;
        }
        get
        {
            return pinCod;
        }
    }
    public override string ToString()
    {
        return houseNo + "  " + houseName + " " + pinCod;
    }


    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;
        private Address empAddress;

        public int EmpNo
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        public string EmpName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }



        }
        public double EmpSal
        {
            set
            {
                empSal = value;
            }
            get
            {
                return empSal;
            }
        }
        public Address EmpAddress
        {
            set
            {
                empAddress = value;
            }
            get
            {
                return empAddress;
            }
        }
    }


       
        class Chetu
    {
        static void Main1()
        {
            Console.WriteLine("enter the Empno");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Empnane");
            string b = Console.ReadLine();
            Console.WriteLine("enter the Empsal");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the houseno");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the housename");
            string e = Console.ReadLine();
            Console.WriteLine("enter the pincod");
            int f = int.Parse(Console.ReadLine());

            Employee emp = new Employee();
            emp.EmpNo = a;
            emp.EmpName = b;
            emp.EmpSal=c;

            Address add = new Address();
            add.HouseNo=d;
            add.HouseName=e;
            add.pinCod=f;
            emp.EmpAddress=add;



            Console.WriteLine("EMPLOYEE ----------------------INFORMATION");
            Console.WriteLine("No is" + " " + emp.EmpNo);
            Console.WriteLine("employee Name is" + " " + emp.EmpName);
            Console.WriteLine("employee sal is" + " " + emp.EmpSal);
            Console.WriteLine("employee address is" + " " + emp.EmpAddress);
        }
    }
}


