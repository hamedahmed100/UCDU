using UCDU.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class MessagesRepository
    {
        readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;




        //public List<Messages> GetAllMessages()
        //{
        //    var messages = new List<Messages>();
        //    using (var connection = new SqlConnection(_connString))
        //    {
        //        connection.Open();
        //        // using (var command = new SqlCommand(@"SELECT [MessageID], [Message], [EmptyMessage], [Date] FROM [dbo].[Messages]", connection))
        //        using (var command = new SqlCommand(@"SELECT m.Message FROM [dbo].Messages m where MessageID >1 ", connection))
        //        {
        //            command.Notification = null;

        //            var dependency = new SqlDependency(command);
        //            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

        //            if (connection.State == ConnectionState.Closed)
        //                connection.Open();

        //            var reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                //  messages.Add(item: new Messages { MessageID = (int)reader["MessageID"], Message = (string)reader["Message"], EmptyMessage = reader["EmptyMessage"] != DBNull.Value ? (string)reader["EmptyMessage"] : "", MessageDate = Convert.ToDateTime(reader["Date"]) });
        //                messages.Add(item: new Messages { Message = (string)reader["Message"] });

        //            }
        //        }

        //    }
        //    return messages;

        //}

        public List<Register> GetAllMessages()
        {
            var rgs = new List<Register>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
               //  using (var command = new SqlCommand(@"SELECT [MessageID], [Message], [EmptyMessage], [Date] FROM [dbo].[Messages]", connection))
               using (var command = new SqlCommand(@"select [NID] , [CID],[billNum]  from [dbo].register ", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //  messages.Add(item: new Messages { MessageID = (int)reader["MessageID"], Message = (string)reader["Message"], EmptyMessage = reader["EmptyMessage"] != DBNull.Value ? (string)reader["EmptyMessage"] : "", MessageDate = Convert.ToDateTime(reader["Date"]) });
                        rgs.Add(item: new Register { NID = (long)reader["NID"], CID = (int)reader["CID"] });

                    }
                }

            }

            

            
            return rgs;

        }

        //GetNotification
        public List<Wait> GetAllNotification(long NID)
        {
            var Notifiy = new List<Wait>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand($"exec sendNotification {NID}", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Notifiy.Add(
                            item: new Wait {
                                NID = (long)reader["NID"],
                                CID = (int)reader["cid"],
                                Title = (string)reader["title"],
                                Date = (string)reader["dates"]
                            });
                    }
                }

            }
            return Notifiy;

        }




        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendMessages();
            }
        }




    }
}







//public List<Wait> GetAllNotification(long NID)
//{
//    var Notifiy = new List<Wait>();
//    using (var connection = new SqlConnection(_connString))
//    {

//        // string stm = $"exec sendNotification {NID}";

//        connection.Open();
//        using (var command = new SqlCommand($"exec sendNotification {NID}", connection))
//        {
//            command.Notification = null;

//            var dependency = new SqlDependency(command);
//            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

//            if (connection.State == ConnectionState.Closed)
//                connection.Open();

//            var reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                Notifiy.Add(item:
//                    new Wait
//                    {
//NID = (long)reader["NID"],
//                        CID = (int)reader["cid"],
//                        Title = (string)reader["title"],
//                        Date = (string)reader["dates"]




//                                      ) });
//        }
//    }

//}
//            return Notifiy;

//}