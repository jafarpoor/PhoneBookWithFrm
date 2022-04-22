namespace BussinesObject
{
   public class Email
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public Person Person { get; set; }
        public EnEmailType EmailType { get; set; }
    }
}
