using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PixApi.Data;
using PixApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixApiTest
{
    public class DbInMemory
    {
        private ApplicationDbContext _context;

        public DbInMemory()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connection)
                .EnableSensitiveDataLogging()
                .Options;

            _context = new ApplicationDbContext(options);
            InsertFakeData();
        }

        public ApplicationDbContext GetContext() => _context;

        private void InsertFakeData()
        {
            if (_context.Database.EnsureCreated())
            {
                _context.clientes.Add
                    (
                        new Cliente()
                        {
                            ClienteNome = "Joao",
                            pix = new Pix()
                            {
                                Chave = "Joao@gmal.com",
                            }
                        }
                    );

                _context.clientes.Add
                    (
                        new Cliente()
                        {
                            ClienteNome = "Pedro",
                            pix = new Pix()
                            {
                                Chave = "Pedro@gmail.com"
                            }
                        }
                    );
                
                _context.transasoes.Add
                    (
                        new Transacao()
                        {
                            ClientePagador = new Cliente()
                            {
                                ClienteNome = "Maria",
                                pix = new Pix()
                                {
                                    Chave = "Maria@gmail.com"
                                }
                            },

                            ClienteRecebedor = new Cliente()
                            {
                                ClienteNome = "Claudia",
                                pix = new Pix()
                                {
                                    Chave = "Claudia@gmail.com"
                                }
                            },

                            PixClientePagador = "Maria@gmail.com",
                            PixClienteRecebedor = "Claudia@gmail.com",
                            ValorDaTransacao = 200
                        }
                    );

                _context.SaveChanges();
            }
        }
    }
}
