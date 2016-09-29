
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public interface IQuestionRepository
    {
        IQueryable<Question> Questions { get; }
        Question Save(Question question);
        Question Edit(Question question);
        void Remove(Question question);
    }
}
