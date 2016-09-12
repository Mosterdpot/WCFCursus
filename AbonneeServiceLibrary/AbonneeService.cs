using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace AbonneeServiceLibrary
{
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class AbonneeService : IAbonneeService
    {
        private static ConnectionStringSettings connectionStringSettings
            = ConfigurationManager.ConnectionStrings["abonnees"];
        private static DbProviderFactory dbProviderFactory
            = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);

        [OperationBehavior(TransactionScopeRequired = true)]
        public void VoegPersoonToe(Persoon persoon)
        {
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                dbConnection.ConnectionString = connectionStringSettings.ConnectionString;
                using (DbCommand dbZoekEmailAdresCommand =
                ZoekEmailAdresCommand(persoon.EmailAdres, dbConnection),
                dbVoegPersoonToeCommand = VoegPersoonToeCommand(persoon, dbConnection))
                {
                    dbConnection.Open();
                    // abonnee enkel toevoegen als hij nog niet voorkomt:
                    if (dbZoekEmailAdresCommand.ExecuteScalar() == null)
                        dbVoegPersoonToeCommand.ExecuteNonQuery();
                }
            }
        }

        private DbCommand ZoekEmailAdresCommand(string emailAdres, DbConnection dbConnection)
        {
            var dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandType = CommandType.Text;
            dbCommand.CommandText =
            "select EmailAdres from Abonnees where EmailAdres=@emailAdres";
            var dbParameterEmailAdres = dbCommand.CreateParameter();
            dbParameterEmailAdres.ParameterName = "emailAdres";
            dbParameterEmailAdres.Value = emailAdres;
            dbCommand.Parameters.Add(dbParameterEmailAdres);
            return dbCommand;
        }

        private DbCommand VoegPersoonToeCommand(Persoon persoon,
        DbConnection dbConnection)
        {
            var dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandType = CommandType.Text;
            dbCommand.CommandText =
            "insert into Abonnees(Voornaam,Familienaam,EmailAdres) " +
            "values(@voornaam,@familienaam,@emailAdres)";
            var dbParameterVoornaam = dbCommand.CreateParameter();
            dbParameterVoornaam.ParameterName = "voornaam";
            dbParameterVoornaam.Value = persoon.Voornaam;
            dbCommand.Parameters.Add(dbParameterVoornaam);
            var dbParameterFamilienaam = dbCommand.CreateParameter();
            dbParameterFamilienaam.ParameterName = "familienaam";
            dbParameterFamilienaam.Value = persoon.Familienaam;
            dbCommand.Parameters.Add(dbParameterFamilienaam);
            var dbParameterEmailAdres = dbCommand.CreateParameter();
            dbParameterEmailAdres.ParameterName = "emailAdres";
            dbParameterEmailAdres.Value = persoon.EmailAdres;
            dbCommand.Parameters.Add(dbParameterEmailAdres);
            return dbCommand;
        }
    }
}
