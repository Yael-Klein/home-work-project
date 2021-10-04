using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
   public class HwBL
    {
        public List<HwToStydyClassOnDateDTO> GetHW()
        {
            HwDAL hwDAL = new HwDAL();
           // TeacherDAL tDaL = new TeacherDAL();

            List<HwToStydyClassOnDateDTO> listDTO = new List<HwToStydyClassOnDateDTO>();

            foreach (var item in hwDAL.GetHW().ToList())
            {
                HwToStydyClassOnDateDTO hwDTO = new HwToStydyClassOnDateDTO();
               //צריך את המפתח הראשי?
                hwDTO.studyClassId = (int)item.studyClassId;
                hwDTO.hwToStydyClassOnDate_Date = (DateTime)item.hwToStydyClassOnDate_Date;
                hwDTO.hwDescription = item.hwDescription;
                hwDTO.deadline = (DateTime)item.deadline;
                hwDTO.durationOfPreparation = (int)item.durationOfPreparation;
                hwDTO.verificationQuestion = item.verificationQuestion;
                hwDTO.verificationAnswer = (int)item.verificationAnswer;
                listDTO.Add(hwDTO);
            }
            return listDTO;
        }

        public int AddHw(HwToStydyClassOnDateDTO hwDTO)
        {
            HwToStydyClassOnDate hw = new HwToStydyClassOnDate();
            Teacher teacher = new Teacher();
            
            hw.studyClassId =hwDTO.studyClassId;
            hw.hwToStydyClassOnDate_Date = hwDTO.hwToStydyClassOnDate_Date;
            hw.hwDescription = hwDTO.hwDescription;
            hw.deadline = hwDTO.deadline;
            hw.durationOfPreparation = hwDTO.durationOfPreparation;
            hw.verificationQuestion = hwDTO.verificationQuestion;
            hw.verificationAnswer = hwDTO.verificationAnswer;

            HwDAL hwDAL = new HwDAL();
            int result =  hwDAL.AddHw(hw);
            return result;
        }

    }
}
