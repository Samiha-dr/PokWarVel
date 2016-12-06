using MarvelApi.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PokWarVel.Models
{
    public class EvalModel
    {
        private Characters monHero;
        private long idHero;
        private int cote;
        private DateTime date;
        private string comment;

        public Characters MonHero
        {
            get { return monHero; }
            set { monHero = value; }
        }

        
        public long IdHero
        {
            get { return idHero; }
            set { idHero = value; }
        }

        public int Cote
        {
            get { return cote; }
            set { cote = value; }
        }

        public DateTime Date
        {
            get { return DateTime.Now(); }
           
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public bool Save()
            {
                SqlConnection Ocon =new SqlConnection();

             
                try
                {
                    Ocon.ConnectionString = @"Data Source=26R2-07\WADSQL;Initial Catalog=eval;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                    Ocon.Open();

                    //SqlCommand Cmd = new SqlCommand();
                    //Cmd.CommandText = @"insert into evalHero (idHero, cote, date,comment) values(@idHero, @cote, @date, @comment)";
                    //Cmd.Connection = Ocon;

                    SqlCommand Cmd = new SqlCommand(@"insert into evalHero (idHero, cote, date,comment) values(@idHero, @cote, @date, @comment)", Ocon);


                    SqlParameter pidHero = new SqlParameter("@idHero", this.IdHero);
                    SqlParameter pcote = new SqlParameter("@cote", this.cote);
                    SqlParameter pdate = new SqlParameter("@date", this.date);
                    SqlParameter pcomment = new SqlParameter("@comment", this.comment);

                    Cmd.Parameters.Add(pidHero);
                    Cmd.Parameters.Add(pcote);
                    Cmd.Parameters.Add(pdate);
                    Cmd.Parameters.Add(pcomment);

                    Cmd.ExecuteNonQuery();
                    Ocon.Close();
                    return true;
                }
                catch (Exception)
                {
                    if (Ocon.State == System.Data.ConnectionState.Open) Ocon.Close();

                    
                }
                return false;
            }

            
    }
}