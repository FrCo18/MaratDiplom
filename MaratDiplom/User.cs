namespace MaratDiplom
{
    class User
    {
        public int id;
        public string first_name;
        public string last_name;
        public string middle_name;
        public string email;
        public string phone;
        public string type;

        public User(
            int id,
            string email,
            string first_name,
            string last_name,
            string middle_name,
            string phone,
            string type
            )
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.middle_name = middle_name;
            this.email = email;
            this.phone = phone;
            this.type = type;
        }
    }
}
