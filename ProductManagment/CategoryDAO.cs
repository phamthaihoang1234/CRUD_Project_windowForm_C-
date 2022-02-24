using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment
{
    internal class Category
    {
        public string cateId { get; set; }
        public string cateName { get; set; }
        public string desc { get; set; }
    }
    internal class CategoryDAO : DAO
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        public List<Category> getListCategory()
        {
            List<Category> list = new List<Category>();
            connect = new SqlConnection(GetConnectionString());
            command = new SqlCommand("SELECT * FROM Categories", connect);

            try
            {
                connect.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if(reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        list.Add(new Category
                        {
                            cateId = reader.GetString("CategoryId"),
                            cateName = reader.GetString("CategoryName"),
                            desc = reader.GetString("Description")

                        });
                    }
                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                connect.Close();
            }
            return list;
        }

        public DataSet getAllCategory()
        {
            connect = new SqlConnection(GetConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            connect.Close();

            return ds;
        }

        public DataTable getAllProduct()
        {
            string sql = "SELECT * FROM Products";
            SqlConnection con = new SqlConnection(GetConnectionString());
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool insert(Product p)
        {
            string sql = "INSERT INTO Products(ProductId,ProductName,CategoryId,Unit,Price,Quantity,Discontinued,CreateDate) VALUES(@ProductId,@ProductName,@CategoryId,@Unit,@Price,@Quantity,@Discontinued,@CreateDate)";
            SqlConnection con = new SqlConnection(GetConnectionString());
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductId", SqlDbType.Char).Value = p.ProductId ;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = p.ProductName ;
                cmd.Parameters.Add("@CategoryId", SqlDbType.Char).Value = p.CategoryId;
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = p.Unit;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value =p.Price ;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = p.Quantity;
                cmd.Parameters.Add("@Discontinued", SqlDbType.NVarChar).Value = p.Discontinued;
                cmd.Parameters.Add("@CreateDate", SqlDbType.NVarChar).Value = p.CreateDate ;
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool update(Product p)
        {
            string sql = "UPDATE Products SET ProductId = @ProductId , ProductName=@ProductName, CategoryId=@CategoryId, Unit=@Unit, Price=@Price, Quantity=@Quantity, Discontinued=@Discontinued, CreateDate=@CreateDate WHERE ProductId = @ProductId";
            SqlConnection con = new SqlConnection(GetConnectionString());
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductId", SqlDbType.Char).Value = p.ProductId;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = p.ProductName;
                cmd.Parameters.Add("@CategoryId", SqlDbType.Char).Value = p.CategoryId;
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = p.Unit;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = p.Price;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = p.Quantity;
                cmd.Parameters.Add("@Discontinued", SqlDbType.NVarChar).Value = p.Discontinued;
                cmd.Parameters.Add("@CreateDate", SqlDbType.Date).Value = p.CreateDate;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool delete(Product p)
        {
            string sql = "DELETE Products WHERE ProductId = @ProductId";
            SqlConnection con = new SqlConnection(GetConnectionString());
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductId", SqlDbType.NVarChar).Value = p.ProductId;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
