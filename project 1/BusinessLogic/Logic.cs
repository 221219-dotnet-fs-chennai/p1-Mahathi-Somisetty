using Model;
using Core_EF;



namespace BusinessLogic
{
    public class Logic : ILogic
    {
        IRepo data;

        public Logic(string connectionString)
        {
            data = new Sqlrepo(connectionString);

        }
        public IEnumerable<Details> GetTraineeDetails()
        {
            return data.GetTraineeDetails();
        }
    }
}