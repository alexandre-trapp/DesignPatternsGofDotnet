using System;

namespace DesignPatternsGofDotnet.Structural.Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class CustomersBase
    {
        protected string _group;

        public DataObject Data { get; set; }

        public CustomersBase(string group)
        {
            _group = group;
        }

        public virtual void Next()
        {
            Data.NextRecord();
        }

        public virtual void Prior()
        {
            Data.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            Data.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            Data.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            Data.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + _group);
            Data.ShowAllRecords();
        }
    }
}
