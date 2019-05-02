/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Student;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOStudent;

/**
 *
 * @author alulab14
 */
public class MySQLStudent implements DAOStudent{

    @Override
    public ArrayList<Student> queryAll() {
        ArrayList<Student> students = new ArrayList<Student>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM Student";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                Student s = new Student();
                s.setIdStudent(rs.getInt("User_idStudent"));           
                students.add(s);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return students;
    }

    @Override
    public int insert(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("" + "{call insertStudent(?,?,?,?,?,?)}");
            cs.setInt(1, student.get_Class());
            cs.setString(2, student.getSection());
            cs.setString(3, student.getCondition());
            cs.setInt(4, student.getIdStudent());
            cs.setInt(5, student.getIdGuardian());
            cs.setInt(6, student.getIdClassSection());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }

    @Override
    public int update(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateStudent(?,?,?,?,?,?)}");
            cs.setInt(1, student.getIdStudent());
            cs.setInt(2, student.get_Class());
            cs.setString(3, student.getSection());
            cs.setString(4, student.getCondition());
            cs.setInt(5, student.getIdGuardian());
            cs.setInt(6, student.getIdClassSection());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }

    @Override
    public int delete(Student student) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteStudent(?)}");
            cs.setInt(1, student.getIdStudent());
            result= cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }
    
}
