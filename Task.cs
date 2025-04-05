using System.Dynamic;

namespace Task_Manager
{

    public class Task
    {
        //fields
        private string name = "";
        private string progess = "";

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }

        }


        public string Progress
        {
            get {return Progress;}
            set {Progress = value;}
        }

    }
}