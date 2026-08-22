namespace ZeroPlayersOnline.DataTypes {
    public class Connection { 
        public string Destination = "";

        public Requirement? Requirement = null;

        public Connection(string dest, Requirement? req = null) { 
            Destination = dest;
            Requirement = req;
        }
    }
}
