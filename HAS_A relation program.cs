using System;
class Address
{
    private int houseNo;
    private string houseName;
    private int pinCod;
    public  Address(int houseNo,string houseName,int pinCod)
    {
        this.houseNo = houseNo;
        this.houseName = houseName;
        this.pinCod = pinCod;
    }
   
       
    
   
       
    
    public int tHouseNo
    {
        get
        {
            return houseNo;

        }
    }
        
    public string GetHouseName
    {
        get
        {
            return houseName;
        }
    }
    public int GetPinCod
    {
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

        public  Employee(int empno,string Empname,double Empsal,Address Empaddress)
        {
            empNo = empno;
            empName = Empname;
            empSal = Empsal;
            empAddress = Empaddress;
        }
      

        public int EmpNo
        {
            get
            {
                return empNo;
            }
            
        }
        public string EmpName
        {
            get
            {
                return empName;
            }


        }
        public double EmpSal
        {
            get
            {
                return empSal;
            }
        }
        public Address EmpAddress
        {
            get
            {
                return empAddress;
            }
        }

    }
    class Chetu
    {
        static void Main()
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

            
            

            Address add = new Address(d,e,f);
           
          //  emp.EmpAddress=add;

            Employee emp = new Employee(a,b,c,add);

            Console.WriteLine("No is" + " " + emp.EmpNo);
            Console.WriteLine("employee Name is" + " " + emp.EmpName);
            Console.WriteLine("employee sal is" + " " + emp.EmpSal);
            Console.WriteLine("employee address is" + " " + emp.EmpAddress);
        }
    }
}
       


