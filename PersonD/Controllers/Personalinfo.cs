using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Person_D.models;

namespace Api_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class PersonalInfoController : ControllerBase
    {
        // GET: api/<userController>
        [HttpGet]
        public IActionResult Get()
        {
            string connectionString = @"Data Source=DESKTOP-PERSV88;Initial Catalog=details;Integrated Security=True";
            string query = "Select * from personalinfo";
            List<Personal> adduser = new List<Personal>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Personal user = new Personal();
                                user.FirstName = reader.GetString(0);
                                user.LastName = reader.GetString(1);
                                user.Age = reader.GetInt32(2);
                                user.Gender = reader.GetString(3);
                                user.Province = reader.GetString(4);
                                adduser.Add(user);
                            }
                        }
                    }
                }
                return Ok(adduser);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



        // GET api/<userController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // POST api/<userController>
        [HttpPost]
        public IActionResult Post([FromBody] Personal personalinfo)
        {
            if (personalinfo == null)
            {
                return BadRequest();
            }



            string connectionString = @"Data Source=DESKTOP-PERSV88;Initial Catalog=details;Integrated Security=True";
            string query = "INSERT INTO personalinfo (FirstName, LastName, Age, Gender, Province) VALUES (@FirstName, @LastName, @Age, @Gender,@Province )";
            try
            {



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", personalinfo.FirstName);
                        command.Parameters.AddWithValue("@LastName", personalinfo.LastName);
                        command.Parameters.AddWithValue("@Age", personalinfo.Age);
                        command.Parameters.AddWithValue("@Gender", personalinfo.Gender);
                        command.Parameters.AddWithValue("@Province", personalinfo.Province);
                        command.ExecuteNonQuery();
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("getinvolved")]
        public IActionResult PostGetinvolved([FromBody] GetInvolved getinvolved)
        {
            if (getinvolved == null)
            {
                return BadRequest();
            }



            string connectionString = @"Data Source=DESKTOP-PERSV88;Initial Catalog=details;Integrated Security=True";
            string query = "INSERT INTO getinvolved (Name, Email, CellNum, Message) VALUES (@Name, @Email, @CellNum, @Message)";
            try
            {



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", getinvolved.Name);
                        command.Parameters.AddWithValue("@Email", getinvolved.Email);
                        command.Parameters.AddWithValue("@CellNum", getinvolved.CellNum);
                        command.Parameters.AddWithValue("@Message", getinvolved.Message);
                        command.ExecuteNonQuery();
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("sell")]
        public IActionResult PostGetinvolve([FromBody] Sell sell)
        {
            if (sell == null)
            {
                return BadRequest();
            }



            string connectionString = @"Data Source=DESKTOP-PERSV88;Initial Catalog=details;Integrated Security=True";
            string query = "INSERT INTO sell (ModelName, EngineCapacity, YearModel, Mileage, Transmission, Color, Condition, FuelType, Price, Message) VALUES (@ModelName, @EngineCapacity, @YearModel, @Mileage, @Transmission, @Color, @Condition,@FuelType, @Price, @Message )";
            try
            {



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ModelName", sell.ModelName);
                        command.Parameters.AddWithValue("@EngineCapacity", sell.EngineCapacity);
                        command.Parameters.AddWithValue("@YearModel", sell.YearModel);
                        command.Parameters.AddWithValue("@Mileage", sell.Mileage);
                        command.Parameters.AddWithValue("@Transmission", sell.Transmission);
                        command.Parameters.AddWithValue("@Color", sell.Color);
                        command.Parameters.AddWithValue("@Condition", sell.Condition);
                        command.Parameters.AddWithValue("@FuelType", sell.FuelType);
                        command.Parameters.AddWithValue("@Price", sell.Price);
                        command.Parameters.AddWithValue("@Message", sell.Message);
                        command.ExecuteNonQuery();
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("testdrive")]
        public IActionResult PostTestDrive([FromBody] TestDrive testdrive)
        {
            if (testdrive == null)
            {
                return BadRequest();
            }



            string connectionString = @"Data Source=DESKTOP-PERSV88;Initial Catalog=details;Integrated Security=True";
            string query = "INSERT INTO testdrive (FullName, Email, PhoneNumber, Date, Time) VALUES (@FullName, @Email, @PhoneNumber, @Date, @Time)";
            try
            {



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", testdrive.FullName);
                        command.Parameters.AddWithValue("@Email", testdrive.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", testdrive.PhoneNumber);
                        command.Parameters.AddWithValue("@Date", testdrive.Date);
                        command.Parameters.AddWithValue("@Time", testdrive.Time);
                        command.ExecuteNonQuery();
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<userController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }



        // DELETE api/<userController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}