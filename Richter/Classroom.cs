using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter
{
    public sealed class Classroom
    {
        private List<String> m_students = new List<String>();
        public List<String> Students { get { return m_students; } }
        public Classroom() { }
    }
}
