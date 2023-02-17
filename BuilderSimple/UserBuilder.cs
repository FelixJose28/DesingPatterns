using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSimplePattern
{
    public class UserBuilder
    {
        private User User;
        private List<string> NickNames;
        public UserBuilder()
        {
            this.Reset();
            this.NickNames = new List<string>();
        }
        public UserBuilder name(string name)
        {
            User.Name = name;
            return this;
        }
        public UserBuilder lastName(string lastName)
        {
            User.LastName = lastName;
            return this;
        }
        public UserBuilder height(int height)
        {
            User.Height = height;
            return this;
        }
        public UserBuilder weight(int weight)
        {
            User.Weight = weight;
            return this;
        }
        public UserBuilder nicknames(string nickName)
        {
            this.NickNames.Add(nickName);
            this.User.Nicknames = this.NickNames;
            return this;
        }
        public void Reset()
        {
            this.User = new User();
        }
        public User Build()
        {
            var userReturned = this.User;
            this.Reset();
            return userReturned;
        } 
    }
}
