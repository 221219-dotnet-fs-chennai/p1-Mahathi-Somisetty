using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_EF;

namespace Model
{
    public interface IRepo
    {
        List<Core_EF.Entities.TraineeDetail> GetTraineeDetails();
    }
}
