using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
        }

        String sFileName, sSelectedPath;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "MYSQL Files|*.sql";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                textBox1.Text = choofdlog.FileName;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPath = fbd.SelectedPath;
                textbox2.Text = fbd.SelectedPath;
            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (textbox2.Text != "")
                {
                    string full = textbox2.Text + "\\Makkah_Software.sql";

                    using (Conn.ConnectionString)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                

                                cmd.Connection = Conn.ConnectionString;
                                Conn.ConnectionString.Open();


                              



                                mb.ExportToFile(full);//This line will export the file to given path.
                                Conn.ConnectionString.Close();
                                Cursor.Current = Cursors.Arrow;
                                alert aa = new alert("Success!", "Backup Successfully Created At " + textbox2.Text, "success");
                                aa.ShowDialog();
                            }
                        }
                    }
                }
                else
                {
                    alert aa = new alert("Error!", "Please Select A Path.", "error");
                    aa.ShowDialog();
                }
            }
              }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "Something Going Wrong While Creating Backup,Please Try Again.", "error");
                aa.ShowDialog();
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForInternetConnection().ToString() == "True")
                {
                    if (textBox1.Text != "")
                    {
                        using (Conn.ConnectionString)
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    alert aaa = new alert("Wait!", "Backup Restoring In Proccess, Please Wait till Success Alert Don't Popup.", "info");
                                    aaa.ShowDialog();
                                    Cursor.Current = Cursors.WaitCursor;
                                    cmd.Connection = Conn.ConnectionString;
                                    Conn.ConnectionString.Open();
                                    mb.ImportFromFile(textBox1.Text);



                                    string sp1 = "CREATE PROCEDURE `discount_card` (IN `cid` INT)  NO SQL COMMENT 'no comment' SELECT c.Customer_Name,c.Customer_Phone,d.DC_Card_Number,d.Serial_Number,d.DC_Start_Date from customers_pos c join discount_card_pos d on d.DC_Customer_ID=c.Customer_ID where c.Customer_ID=cid";
                                    MySqlCommand cp1 = new MySqlCommand(sp1, Conn.ConnectionString);

                                    string sp2 = "CREATE PROCEDURE `for_discount_card_holder` (IN `idd` INT)  NO SQL COMMENT 'no comment' SELECT CONCAT(brandd.Product_Brand_Name ,' ', product.Product_Name,' (',product.Product_Model,')') as 'Product Name',saleproduct.Sale_Product_Price as 'Product Price',saleproduct.Sale_Product_Discounted_Amount as 'Discount',saleproduct.Sale_Discounted_Price as 'Total Amount',saleproduct.Sale_Product_Quantity as 'Product Quantity',orderr.Order_Date as 'Order Date',orderr.Order_Type as 'Type',orderr.Order_Total_Price as 'Net Amount',orderr.Order_Paid_Amount as 'Paid Amount',orderr.Order_ID,orderr.Order_Paid_Amount_By_Point,orderr.Serial_Number as 'Serial Number',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',customer.Customer_Phone,dc.DC_Current_Points as 'Available Points' from `products_pos` product join product_brands_pos brandd on brandd.Product_Brand_ID=product.Pro_Brand_ID join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join discount_card_pos dc on dc.DC_Customer_ID=customer.Customer_ID where orderr.Order_ID=idd";
                                    MySqlCommand cp2 = new MySqlCommand(sp2, Conn.ConnectionString);

                                    string sp3 = "CREATE PROCEDURE `for_sale_report` (IN `id` INT)  NO SQL COMMENT 'no comment' SELECT CONCAT(brandd.Product_Brand_Name ,' ', product.Product_Name,' (',product.Product_Model,')') as 'Product Name',saleproduct.Sale_Product_Price as 'Product Price',saleproduct.Sale_Product_Discounted_Amount as 'Discount',saleproduct.Sale_Discounted_Price as 'Total Amount',saleproduct.Sale_Product_Quantity as 'Product Quantity',orderr.Order_Date as 'Order Date',orderr.Order_Type as 'Type',orderr.Order_Total_Price as 'Paid Amount',orderr.Order_ID,orderr.Order_Paid_Amount_By_Point,orderr.Serial_Number as 'Serial Number',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',customer.Customer_Phone from `products_pos` product join product_brands_pos brandd on brandd.Product_Brand_ID=product.Pro_Brand_ID join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where orderr.Order_ID=id";
                                    MySqlCommand cp3 = new MySqlCommand(sp3, Conn.ConnectionString);


                                    string sp4 = "CREATE PROCEDURE `get_single_bank_data_pos` (IN `banks` VARCHAR(255))  NO SQL BEGIN SELECT * FROM `banks_pos` WHERE `banks_pos`.`Bank_Name` Like CONCAT( banks , '%'); END";
                                    MySqlCommand cp4 = new MySqlCommand(sp4, Conn.ConnectionString);


                                    string sp5 = "CREATE PROCEDURE `get_single_bank_details_pos` (IN `bank` VARCHAR(255))  NO SQL BEGIN SELECT `bd`.`Bank_Details_ID` AS `Bank_ID`, `b`.`Bank_Name` AS `Bank Name`, `bd`.`Bank_Branch` AS `Bank Branch`, `bd`.`Bank_Acc_Name` AS `Account Name`, `bd`.`Bank_Acc_Number` AS `Account Number`, `bd`.`Bank_Acc_Balance` AS `Current Balance`, if((`bd`.`Bank_Acc_Status` = 0),'Active','InActive') AS `Account Status` from `bk_ims`.`bank_details_pos` `bd` join `bk_ims`.`banks_pos` `b` on `bd`.`Bank_Name_ID` = `b`.`Bank_ID` WHERE `b`.`Bank_Name` Like CONCAT( bank , '%') OR `bd`.`Bank_Branch` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Name` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Number` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Balance` Like CONCAT( bank , '%') OR if((`bk_ims`.`banks_pos`.`Bank_Acc_Status` = 0),'Active','InActive') Like CONCAT( bank , '%'); END";
                                    MySqlCommand cp5 = new MySqlCommand(sp5, Conn.ConnectionString);


                                    string sp6 = "CREATE PROCEDURE `get_single_branch_data_pos` (IN `branch` VARCHAR(255))  BEGIN SELECT Branch_ID AS `Branch ID`, Branch_Area AS `Branch Area`,  Branch_Head AS `Branch Head`, Branch_Phone AS `Branch Phone` FROM `branches_pos` WHERE Branch_Head Like CONCAT( branch , '%') OR Branch_Area Like CONCAT( branch , '%') OR Branch_Phone Like CONCAT( branch , '%'); END";
                                    MySqlCommand cp6 = new MySqlCommand(sp6, Conn.ConnectionString);


                                    string sp7 = "CREATE PROCEDURE `get_single_customer_data_pos` (IN `customer` VARCHAR(255))  NO SQL BEGIN SELECT Customer_ID AS `Customer ID`, Customer_Name AS `Customer Name`,  Customer_Phone AS `Customer Phone`, Customer_Mail AS `Customer Mail`, Customer_Address AS `Customer Address` FROM `customers_pos` WHERE Customer_Name Like CONCAT( customer , '%') OR Customer_Phone Like CONCAT( customer , '%') OR Customer_Mail Like CONCAT( customer , '%') OR Customer_Address Like CONCAT( customer , '%'); END";
                                    MySqlCommand cp7 = new MySqlCommand(sp7, Conn.ConnectionString);


                                    string sp8 = "CREATE PROCEDURE `get_single_customer_for_card` (IN `id` INT)  NO SQL COMMENT 'no comment' SELECT c.Customer_Name,c.Customer_Phone,d.DC_Card_Number,d.DC_Start_Date from customers_pos c join discount_card_pos d on d.DC_Customer_ID=c.Customer_ID where c.Customer_ID=id";
                                    MySqlCommand cp8 = new MySqlCommand(sp8, Conn.ConnectionString);


                                    string sp9 = "CREATE PROCEDURE `get_single_expense_data_pos` (IN `expense` VARCHAR(255))  NO SQL BEGIN SELECT Expense_ID AS `Expense ID`, Expense_Purpose AS `Expense Purpose`, Expense_Amount AS `Expense Amount`, Expense_Date AS `Expense Date` FROM `daily_expense_pos` WHERE Expense_Purpose Like CONCAT( expense , '%') OR Expense_Amount Like CONCAT( expense , '%') OR Expense_Date Like CONCAT( expense , '%'); END";
                                    MySqlCommand cp9 = new MySqlCommand(sp9, Conn.ConnectionString);


                                    string sp10 = "CREATE PROCEDURE `get_single_product_brand_data_pos` (IN `brand` VARCHAR(255))  NO SQL BEGIN SELECT `bk_ims`.`product_brands_pos`.`Product_Brand_ID` AS `Brand ID`, `bk_ims`.`product_brands_pos`.`Product_Brand_Name` AS `Brand Name`, IF(( `bk_ims`.`product_brands_pos`.`Product_Brand_Status` = 0), 'Active',   'InActive') AS `Brand Status` FROM `bk_ims`.`product_brands_pos` WHERE Product_Brand_Name Like CONCAT( brand , '%') OR IF(( `bk_ims`.`product_brands_pos`.`Product_Brand_Status` = 0), 'Active',   'InActive') Like CONCAT( brand , '%'); END";
                                    MySqlCommand cp10 = new MySqlCommand(sp10, Conn.ConnectionString);


                                    string sp11 = "CREATE PROCEDURE `get_single_product_category_data_pos` (IN `category` VARCHAR(255))  NO SQL BEGIN select `pc`.`Product_Category_ID` AS `Category_ID`, `pc`.`Product_Category_Name` AS `Category Name`, `pb`.`Product_Brand_Name` AS `Brand Name`, if((`pc`.`Product_Category_Status` = 0),'Active','InActive') AS `Category Status` from `bk_ims`.`product_category_pos` `pc` join `bk_ims`.`product_brands_pos` `pb` on((`pc`.`Product_Category_Brand_ID` = `pb`.`Product_Brand_ID`)) WHERE if((`pc`.`Product_Category_Status` = 0),'Active','InActive') Like CONCAT( category , '%') OR Product_Category_Name Like CONCAT( category , '%'); END";
                                    MySqlCommand cp11 = new MySqlCommand(sp11, Conn.ConnectionString);


                                    string sp12 = "CREATE PROCEDURE `get_single_product_data_pos` (IN `product` VARCHAR(255))  NO SQL BEGIN select `p`.`Product_ID` AS `Product_ID`,`p`.`Product_Name` AS `Product Name`,`c`.`Product_Category_Name` AS `Product Category Name`,`p`.`Product_Model` AS `Product Model`,`p`.`Product_Material` AS `Product Material`,`p`.`Product_Color` AS `Product Color`,`b`.`Product_Brand_Name` AS `Product Brand Name`,`p`.`Product_Remarks` AS `Product Remarks`,`p`.`Product_Entry_Date` AS `Product Entry Date` from ((`bk_ims`.`products_pos` `p` join `bk_ims`.`product_category_pos` `c` on((`p`.`Product_Cat_ID` = `c`.`Product_Category_ID`))) join `bk_ims`.`product_brands_pos` `b` on((`p`.`Pro_Brand_ID` = `b`.`Product_Brand_ID`))) WHERE Product_Name Like CONCAT( product, '%') OR Product_Model Like CONCAT( product, '%') OR Product_Material Like CONCAT( product, '%') OR Product_Color Like CONCAT( product, '%') OR Product_Remarks Like CONCAT( product, '%') OR Product_Redeem_Points Like CONCAT( product, '%') OR Product_Entry_Date Like CONCAT( product, '%'); END";
                                    MySqlCommand cp12 = new MySqlCommand(sp12, Conn.ConnectionString);


                                    string sp13 = "CREATE PROCEDURE `get_single_purchase_data_pos` (IN `purchase` VARCHAR(255))  NO SQL BEGIN SELECT `p`.`Purchase_ID` AS `Purchase_ID`, `p`.`Purchase_Date` AS `Purchase Date`, CONCAT(`u`.`User_First_Name`, ' ', `u`.`User_Last_Name`) AS `Purchase Done By`, `s`.`Supplier_Company` AS `Supplier Company` FROM `purchase_pos` `p` JOIN `users_pos` `u` ON `p`.`Purchase_Done_By` = `u`.`User_ID` JOIN `suppliers_pos` `s` ON `p`.`Purchase_Supplier_ID` = `s`.`Supplier_ID` WHERE Supplier_Company Like CONCAT( purchase , '%') OR User_First_Name Like CONCAT( purchase , '%') OR User_Last_Name Like CONCAT( purchase , '%'); END";
                                    MySqlCommand cp13 = new MySqlCommand(sp13, Conn.ConnectionString);


                                    string sp14 = "CREATE PROCEDURE `get_single_suppliers_data_pos` (IN `suppliers` VARCHAR(255))  NO SQL select `bk_ims`.`suppliers_pos`.`Supplier_ID` AS `Supplier_ID`,`bk_ims`.`suppliers_pos`.`Supplier_Company` AS `Supplier Company`,`bk_ims`.`suppliers_pos`.`Supplier_Contact_Person` AS `Supplier Contact Person`,`bk_ims`.`suppliers_pos`.`Supplier_Phone` AS `Supplier Phone`,`bk_ims`.`suppliers_pos`.`Supplier_Address` AS `Supplier Address`,`bk_ims`.`suppliers_pos`.`Supplier_CNIC` AS `Supplier CNIC`,`bk_ims`.`suppliers_pos`.`Supplier_Entry_Date` AS `Supplier Entry Date`,if((`bk_ims`.`suppliers_pos`.`Supplier_Status` = 0),'Active','InActive') AS `Supplier Status` from `bk_ims`.`suppliers_pos`";
                                    MySqlCommand cp14 = new MySqlCommand(sp14, Conn.ConnectionString);


                                    string sp15 = "CREATE PROCEDURE `get_single_user_data_pos` (IN `users` VARCHAR(255))  NO SQL select `bk_ims`.`users_pos`.`User_ID` AS `User_ID`,`bk_ims`.`users_pos`.`User_First_Name` AS `First Name`,`bk_ims`.`users_pos`.`User_Last_Name` AS `Last Name`,`bk_ims`.`users_pos`.`User_Mail` AS `Email`,`bk_ims`.`users_pos`.`User_Phone` AS `Phone Number`,`bk_ims`.`users_pos`.`User_Username` AS `Username`,`bk_ims`.`users_pos`.`User_NIC` AS `NIC`,`b`.`Branch_Area` AS `Branch`,`r`.`Role_Name` AS `Role`,`bk_ims`.`users_pos`.`User_Status` AS `Status` from ((`bk_ims`.`users_pos` join `bk_ims`.`branches_pos` `b` on((`b`.`Branch_ID` = `bk_ims`.`users_pos`.`User_Branch_ID`))) join `bk_ims`.`roles_pos` `r` on((`r`.`Role_ID` = `bk_ims`.`users_pos`.`User_Role_ID`))) WHERE User_First_Name Like CONCAT( users , '%') OR User_Last_Name Like CONCAT( users , '%') OR User_Mail Like CONCAT( users , '%') OR User_Phone Like CONCAT( users , '%') OR User_Username Like CONCAT( users , '%') OR `b`.`Branch_Area` Like CONCAT( users , '%') OR `r`.`Role_Name` LIKE CONCAT( users , '%') OR User_NIC LIKE CONCAT( users , '%') OR User_Status LIKE CONCAT( users , '%')";
                                    MySqlCommand cp15 = new MySqlCommand(sp15, Conn.ConnectionString);



                                    string sp16 = "CREATE PROCEDURE `get_user_login_details_pos` (IN `username` VARCHAR(255), IN `password` VARCHAR(255))  BEGIN SELECT U.User_ID as 'ID', U.User_First_Name  as 'First Name', U.User_Last_Name  as 'Last Name', U.User_Username as 'Username', U.User_Pswd as 'Password', U.User_Role_ID as 'Role' from users_pos U join branches_pos b where U.User_Username = username and U.User_Pswd = password and U.User_Status='Active' and b.Branch_Status='Active'; END";
                                    MySqlCommand cp16 = new MySqlCommand(sp16, Conn.ConnectionString);


                                    string sp17 = "CREATE PROCEDURE `purchase_report` (IN `sid` INT, IN `date` INT)  NO SQL COMMENT 'no comment' SELECT CONCAT(p.Product_Name,' (',p.Product_Model,')') as 'Product Name',pd.PD_Product_Price as 'Price',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Quantity as 'Quantity',pd.PD_Product_Total_Price as 'Total',pr.Purchase_Date as 'Date',pr.Serial_Number as 'Sr no',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Phone' FROM products_pos p join purchase_details_pos pd on p.Product_ID=pd.PD_Product_ID join purchase_pos pr on pd.PD_Purchase_ID=pr.Purchase_ID join suppliers_pos s on pr.Purchase_Supplier_ID=s.Supplier_ID where pr.Purchase_Date=date and pr.Purchase_Supplier_ID=sid";
                                    MySqlCommand cp17 = new MySqlCommand(sp17, Conn.ConnectionString);


                                    string sp18 = "CREATE PROCEDURE `purchase_report_net_amount` (IN `sid` INT, IN `date` INT)  NO SQL COMMENT 'no comment' SELECT sum(pd.PD_Product_Total_Price) as 'Net Amount' from purchase_details_pos pd join purchase_pos pr on pd.PD_Purchase_ID=pr.Purchase_ID where pr.Purchase_Date=date and pr.Purchase_Supplier_ID=sid";
                                    MySqlCommand cp18 = new MySqlCommand(sp18, Conn.ConnectionString);


                                    int res1 = cp1.ExecuteNonQuery();
                                    cp2.ExecuteNonQuery();
                                    cp3.ExecuteNonQuery();
                                    cp4.ExecuteNonQuery();
                                    cp5.ExecuteNonQuery();
                                    cp6.ExecuteNonQuery();
                                    cp7.ExecuteNonQuery();
                                    cp8.ExecuteNonQuery();
                                    cp9.ExecuteNonQuery();
                                    cp10.ExecuteNonQuery();
                                    //cp11.ExecuteNonQuery();
                                    cp12.ExecuteNonQuery();
                                    cp13.ExecuteNonQuery();
                                    cp14.ExecuteNonQuery();
                                    cp15.ExecuteNonQuery();
                                    cp16.ExecuteNonQuery();
                                    cp17.ExecuteNonQuery();
                                    int res18 = cp18.ExecuteNonQuery();





                                    Conn.ConnectionString.Close();
                                    Cursor.Current = Cursors.Arrow;
                                    alert aa = new alert("Success!", "Database Successfully Restored.", "success");
                                    aa.ShowDialog();

                                }
                            }
                        }
                    }
                    else
                    {
                        alert aa = new alert("Error!", "Please Select A SQL File.", "error");
                        aa.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "Something Going Wrong While Restoring Backup,Please Try Again.", "error");
                aa.ShowDialog();
            }
        }

        private void backup_Load(object sender, EventArgs e)
        {

        }
    }
}
