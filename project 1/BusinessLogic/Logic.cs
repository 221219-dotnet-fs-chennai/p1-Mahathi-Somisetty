using Trainer;
using Data;

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