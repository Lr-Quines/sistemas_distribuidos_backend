using System.Web.Http;
using MySql.Data.MySqlClient;
using ConsultaMatricula.Records;
using System;

namespace ConsultaMatricula.Controllers
{
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {
        [Route("GetAlunoByMatricula")]
        [HttpGet]
        public IHttpActionResult GetAlunoByMatricula(string matricula)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost; database=uls_sd_g2_trab; username=root; password=;"))
            {
                connection.Open();

                string query = "SELECT * FROM sd_alunos WHERE txMatricula = @txMatricula";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@txMatricula", matricula);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Aluno aluno = new Aluno
                            {
                                Id = reader["id"] != DBNull.Value ? reader.GetInt64("id") : 0,
                                TxNome = reader["txNome"] != DBNull.Value ? reader.GetString("txNome") : string.Empty,
                                DtNascimento = reader["dtNascimento"] != DBNull.Value ? reader.GetDateTime("dtNascimento") : DateTime.MinValue,
                                TxGenero = reader["txGenero"] != DBNull.Value ? reader.GetString("txGenero") : string.Empty,
                                TxMatricula = reader["txMatricula"] != DBNull.Value ? reader.GetString("txMatricula") : string.Empty,
                                TxCurso = reader["txCurso"] != DBNull.Value ? reader.GetString("txCurso") : string.Empty,
                                DtMatricula = reader["dtMatricula"] != DBNull.Value ? reader.GetDateTime("dtMatricula") : DateTime.MinValue,
                                TxStatusMatricula = reader["txStatusMatricula"] != DBNull.Value ? reader.GetString("txStatusMatricula") : string.Empty,
                                TxCep = reader["txCep"] != DBNull.Value ? reader.GetString("txCep") : string.Empty,
                                TxUF = reader["txUF"] != DBNull.Value ? reader.GetString("txUF") : string.Empty,
                                TxCidade = reader["txCidade"] != DBNull.Value ? reader.GetString("txCidade") : string.Empty,
                                TxRua = reader["txRua"] != DBNull.Value ? reader.GetString("txRua") : string.Empty,
                                TxNro = reader["txNro"] != DBNull.Value ? reader.GetString("txNro") : string.Empty,
                                TxFone1 = reader["txFone1"] != DBNull.Value ? reader.GetString("txFone1") : string.Empty,
                                TxFone2 = reader["txFone2"] != DBNull.Value ? reader.GetString("txFone2") : string.Empty,
                                TxEmail = reader["txEmail"] != DBNull.Value ? reader.GetString("txEmail") : string.Empty,
                                TxNomeMae = reader["txNomeMae"] != DBNull.Value ? reader.GetString("txNomeMae") : string.Empty,
                                TxNomePai = reader["txNomePai"] != DBNull.Value ? reader.GetString("txNomePai") : string.Empty
                            };

                            return Ok(aluno);
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                }
            }
        }
    }
}