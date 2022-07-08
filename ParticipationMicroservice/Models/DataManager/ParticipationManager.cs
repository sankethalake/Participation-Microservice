using Microsoft.EntityFrameworkCore;
using ParticipationMicroservice.DBContexts;
using ParticipationMicroservice.Model;
using ParticipationMicroservice.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticipationMicroservice.Models.DataManager
{
    public class ParticipationManager: IDataRepository<Participation>
    {
        readonly ParticipationContext _participationContext;
        public ParticipationManager(ParticipationContext context)
        {
            _participationContext = context;
        }

        //method to get all participation
        public IEnumerable<Participation> GetAll()
        {
           var data = _participationContext.Participations.ToList();

            return data;
        }

        //method to get participation by id
        public Participation Get(long id)
        {
            return _participationContext.Participations
                  .FirstOrDefault(p => p.ParticipationId == id);
        }

        //method to get participation by status
        public IEnumerable<Participation> GetByStatus(string status)
        {
            IEnumerable<Participation> participantList= null;
            
                if (Enum.TryParse(status, true, out ParticipationStatus enumStatus))
                {
                    participantList = _participationContext.Participations.Where(s => s.Status == enumStatus);
                }

    
            return participantList;
        }


        //method to add participation
        public void Add(Participation entity)
        {
            _participationContext.Participations.Add(entity);
            _participationContext.SaveChanges();
        }

        //method to update status of participation
        public bool Update(Participation participation, string status)
        {
            ParticipationStatus enumStatus;

            if (Enum.TryParse(status, true, out enumStatus)){
                participation.Status = enumStatus;
                _participationContext.SaveChanges();
                return true;
            }
            return false;
        }

        private bool ValidateStatus(string status)
        {
            return Enum.TryParse(status, true, out ParticipationStatus enumStatus);
        }

    }
}
