﻿using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ContactManager.Entities
{
    public class Contact : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Zip { get; set; }
        public string Town { get; set; }
        public int? CountryId { get; set; }
        public string Notes { get; set; }


        protected override void Delete(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText =
                @"DELETE FROM Contacts 
                  WHERE ContactId = @ContactId";
            command.AddParameter("ContactId", DbType.Int32, Id);
            command.ExecuteNonQuery();
        }

        protected override void Update(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText =
                @"UPDATE Contacts SET FirstName = @FirstName, 
                                      LastName = @LastName,
                                      Company = @Company,
                                      Position = @Position,
                                      AddressLine1 = @AddressLine1,
                                      AddressLine2 = @AddressLine2,
                                      Zip = @Zip,
                                      Town = @Town,
                                      CountryId = @CountryId,
                                      Notes = @Notes
                  WHERE ContactId = @ContactId";
            command.AddParameter("FirstName", DbType.String, FirstName);
            command.AddParameter("LastName", DbType.String, LastName);
            command.AddParameter("Company", DbType.String, Company);
            command.AddParameter("Position", DbType.String, Position);
            command.AddParameter("AddressLine1", DbType.String, AddressLine1);
            command.AddParameter("AddressLine2", DbType.String, AddressLine2);
            command.AddParameter("Zip", DbType.String, Zip);
            command.AddParameter("Town", DbType.String, Town);
            command.AddParameter("CountryId", DbType.Int32, CountryId);
            command.AddParameter("Notes", DbType.String, Notes);
            command.AddParameter("ContactId", DbType.Int32, Id);
            command.ExecuteNonQuery();
        }

        protected override int Insert(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText =
                @"INSERT INTO Contacts ( FirstName, LastName, Company, Position,
                                         AddressLine1, AddressLine2, Zip, Town,
                                         CountryId, Notes ) 
                  VALUES ( @FirstName, @LastName, @Company, @Position,
                          @AddressLine1, @AddressLine2, @Zip, @Town, @CountryId, @Notes )";
            command.AddParameter("FirstName", DbType.String, FirstName);
            command.AddParameter("LastName", DbType.String, LastName);
            command.AddParameter("Company", DbType.String, Company);
            command.AddParameter("Position", DbType.String, Position);
            command.AddParameter("AddressLine1", DbType.String, AddressLine1);
            command.AddParameter("AddressLine2", DbType.String, AddressLine2);
            command.AddParameter("Zip", DbType.String, Zip);
            command.AddParameter("Town", DbType.String, Town);
            command.AddParameter("CountryId", DbType.Int32, CountryId);
            command.AddParameter("Notes", DbType.String, Notes);
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "SELECT @@IDENTITY";
            return ToInt32(command.ExecuteScalar()).Value;
        }

        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            using (DbConnection connection = GetConnection())
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Contacts ORDER BY FirstName, LastName ASC";
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact
                                      {
                                          Id = ToInt32(reader["ContactId"]).Value,
                                          FirstName = ToString(reader["FirstName"]),
                                          LastName = ToString(reader["LastName"]),
                                          Company = ToString(reader["Company"]),
                                          Position = ToString(reader["Position"]),
                                          AddressLine1 = ToString(reader["AddressLine1"]),
                                          AddressLine2 = ToString(reader["AddressLine2"]),
                                          Zip = ToString(reader["Zip"]),
                                          Town = ToString(reader["Town"]),
                                          CountryId = ToInt32(reader["CountryId"])
                                      };
                    contacts.Add(contact);
                }
            }

            return contacts;
        }
    }
}