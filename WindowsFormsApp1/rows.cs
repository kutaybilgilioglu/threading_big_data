using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WindowsFormsApp1
{
    [Serializable]

    public class Rows
    {

        [CsvColumn(Name = "Product", FieldIndex = 1)]
        public string Product { get; set; }
        [CsvColumn(Name = "Issue", FieldIndex = 2)]
        public string Issue { get; set; }
        [CsvColumn(Name = "Company", FieldIndex = 3)]
        public string Company { get; set; }
        [CsvColumn(Name = "State", FieldIndex = 4)]
        public string State { get; set; }
        [CsvColumn(Name = "Complaint ID", FieldIndex = 5)]
        public int ID { get; set; }
        [CsvColumn(Name = "ZIP code", FieldIndex = 6)]
        public string Zip_Code { get; set; }




    }
   

    public class found_index
    {
        private int i;
        private int j;
        private int diff;
        public found_index(int i, int j,int diff)
        {
            this.i = i;
            this.j = j;
            this.diff = diff;
        }
        public int Diff
        {
            get { return diff; }
            set { diff = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public int J
        {
            get { return j; }
            set { j = value; }
        }
    }

    public class Data_set
    {
        private string _product;
        private string _issue;
        private string _company;
        private string _state;
        private string _zip;
        private int _id;
        public Data_set(string product, string issue, string company, string state, int id, string zip)
        {
            this._product = product;
            this._issue = issue;
            this._company = company;
            this._state = state;
            this._id = id;
            this._zip = zip;
        }
        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public string Issue
        {
            get { return _issue; }
            set { _issue = value; }
        }
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ZIP
        {
            get { return _zip; }
            set { _zip = value; }
        }
    }
    public class ui_data
    {
        private int _thread;
        private int _data_count;
        private int _id;
        private int _comp;
        private int _oran;
       
        private int _scenario;
        public ui_data(int thread_, int data_count, int scenario,int id,int comp,int oran)
        {
            this._oran = oran;
            this._id = id;
            this._comp = comp;
            this._thread = thread_;
            this._data_count = data_count;
            this._scenario = scenario;
            
        }
        public int Oran
        {
            get { return _oran; }
            set { _oran = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Comp
        {
            get { return _comp; }
            set { _comp = value; }
        }
        public int Thread_
        {
            get { return _thread; }
            set { _thread = value; }
        }
        public int Count_
        {
            get { return _data_count; }
            set { _data_count = value; }
        }
        
        public int Scenario
        {
            get { return _scenario; }
            set { _scenario = value; }
        }
       
    }







    public class Yazlab_List
    {

        List<Rows> records = new List<Rows>();
        public bool AddRecord(string product, string issue, string company, string state, int id, string zip)
        {
            records.Add(new Rows { Product = product, Issue = issue, Company = company, State = state, ID = id, Zip_Code = zip });
            return true;
        }

    }
}
