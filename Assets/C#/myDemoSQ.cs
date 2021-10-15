using System.Collections;
using UnityEngine;
using Mono.Data.Sqlite; //导入sqlite数据集，也就是Plugins文件夹下的那个dll文件
using System;
using System.Data;  //数据集 是formwork2.0 用vs开发要自己引用框架中的System.Data
using UnityEngine.UI;
public class myDemoSQ : MonoBehaviour
{
    private SqliteConnection dbConnection;    //声明一个连接对象
    private SqliteCommand dbCommand;    //声明一个操作数据库命令
    private SqliteDataReader reader;    //声明一个读取结果集的一个或多个结果流
    public GameObject tishimessage;
    //public InputField field;    /// 数据库的连接字符串，用于建立与特定数据源的连接
    public InputField inname;
    public InputField incode;
    int id = 0;                         //声明一个学生ID号
    void Awake()
    {
        OpenDB("Data Source=./sqlite3.db");             //调用OpenDB函数来连接数据库
        Debug.Log("Data Source=./sqlite3.db");
        CreateTable();
    }
    public void OpenDB(string connectionString){
        try{
            dbConnection = new SqliteConnection(connectionString);  //实例化数据库连接对象
            dbConnection.Open();                //打开数据库
            Debug.Log("Connected to Database");
        }catch (Exception e){
            string error = e.ToString();
            Debug.Log(error);
        }
    }
    public SqliteDataReader ExecuteQuery(string sqlQuery)
    {    /// 执行查询sqlite语句操作
        dbCommand = dbConnection.CreateCommand();       //创建一个数据库命令对象
        dbCommand.CommandText = sqlQuery;           //将CommandText（命令文本）设置为接收到的SQL语句
        reader = dbCommand.ExecuteReader();         //执行命令语句并将返回的结果集赋给reader
        return reader;                      //返回结果集
    }
    public void InsertInto(String uName,String code)
    {    // 向表中添加数据
        
        string query = "INSERT INTO AdminTable VALUES(" + (++id) + ",\""+uName+ "\",\"" + code+ "\")";  //声明一条SQL语句用来向表中添加数据
        
        ExecuteQuery(query);
        Debug.Log(uName);//执行SQL语句
    }
    public void CreateTable()
    {    // 创建数据表
        string query = "CREATE TABLE AdminTable(id int,username VARCHAR(30),code VARCHAR(30))"; //声明一条SQL语句用来创建数据表
        ExecuteQuery(query);                 //执行SQL语句
    }
    public void Register()      //注册函数
    {
        String uName = inname.text;
        String code = incode.text;
        InsertInto(uName, code);
    }
    public void LogOn()     //登录函数
    {   
        
        IDataReader sqReader = ExecuteQuery("select * from AdminTable");          //接收结果集
        while (sqReader.Read())
        {                            //读取结果集中的数据
            if(inname.text== sqReader.GetString(sqReader.GetOrdinal("username"))&&incode.text== sqReader.GetString(sqReader.GetOrdinal("code")))
            {
                tishimessage.SetActive(false);
                Application.LoadLevel("MainMenu");
                break;
            }
            else
            {
                tishimessage.SetActive(true);
            }
        }
    }
}
