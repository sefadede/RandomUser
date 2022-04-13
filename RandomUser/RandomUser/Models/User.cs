using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomUser.Models
{
    [NotMapped]
    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    [NotMapped]
    public class Street
    {
        public int number { get; set; }
        public string name { get; set; }
    }

    [NotMapped]
    public class Coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    [NotMapped]
    public class Timezone
    {
        public string offset { get; set; }
        public string description { get; set; }
    }

    [NotMapped]
    public class Location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }
    }

    [NotMapped]
    public class Login
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }

    [NotMapped]
    public class Dob
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    [NotMapped]
    public class Registered
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    [NotMapped]
    public class Picture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }

    public class User
    {
        [Key]
        public string email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string gender { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
        public Login login { get; set; }
        public Dob dob { get; set; }
        public Registered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Picture picture { get; set; }
        public string nat { get; set; }
    }

    [NotMapped]
    public class Info
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }

    [NotMapped]
    public class Root
    {
        public List<User> results { get; set; }
        public Info info { get; set; }
    }
}
