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
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Exam;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Teacher;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOExam;

/**
 *
 * @author alulab14
 */
public class MySQLExam implements DAOExam{

    @Override
    public ArrayList<Exam> queryAll() {
        ArrayList<Exam> exams = new ArrayList<Exam>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM Exam WHERE active = 1"; //Solo se considerean los examenes que no están dados de baja
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                Exam s = new Exam();
                s.setIdExam(rs.getInt("idExam"));
                s.setDescription(rs.getString("description"));
                s.setState(rs.getString("state"));
                s.setIdTeacher(rs.getInt("idTeacher"));
                s.setIdCourse(rs.getInt("idCourse"));                
                
                exams.add(s);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return exams;
    }

    @Override
    public int insert(Exam exam) {
         int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("" + "{call insertExam(?,?,?,?,?,?,?)}");
            cs.setInt(1, 1);
            cs.setString(2, exam.getDescription());
            cs.setString(3, exam.getState());
            cs.setInt(4,4);
            cs.setInt(5, exam.getIdTeacher());
            cs.setInt(6, exam.getIdCourse());
            result= cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }

    @Override
    public int update(Exam exam) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateExam(?,?,?,?,?,?)}");
            cs.setInt(1, exam.getIdExam());
            cs.setString(2, exam.getDescription());
            cs.setString(3, exam.getState());
            cs.setInt(4, exam.getIdTeacher());
            cs.setInt(5, exam.getIdCourse());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int delete(Exam exam) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteExam(?)}");
			cs.setInt(1, exam.getIdExam());
            result= cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }
    
}
