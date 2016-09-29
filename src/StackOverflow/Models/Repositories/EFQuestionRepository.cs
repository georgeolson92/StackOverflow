using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class EFQuestionRepository : IQuestionRepository
    {
        QuestionDbContext db = new QuestionDbContext();


        public IQueryable<Question> Questions
        { get { return db.Questions; } }

        public Question Save(Question item)
        {
            db.Questions.Add(item);
            db.SaveChanges();
            return item;
        }

        public Question Edit(Question item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return item;
        }

        public void Remove(Question item)
        {
            db.Questions.Remove(item);
            db.SaveChanges();
        }
    }
}
    