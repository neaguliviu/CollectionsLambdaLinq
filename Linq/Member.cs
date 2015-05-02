using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    public class Member
    {
        public int Id { get; set; }

        public int BandId { get; set; }

        public string Name { get; set; }

        public Member(int id, int bandId,string name)
        {
            this.Id = id;
            this.BandId = bandId;
            this.Name = name;
        }
    }
}
