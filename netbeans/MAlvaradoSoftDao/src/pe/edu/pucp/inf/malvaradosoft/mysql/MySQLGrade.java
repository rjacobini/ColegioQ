/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Grade;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOGrade;

/**
 *
 * @author alulab14
 */
public class MySQLGrade implements DAOGrade{

    @Override
    public ArrayList<Grade> queryAll() {
        ArrayList<Grade> grades = new ArrayList<Grade>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM Grade";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                Grade g = new Grade();
                g.setIdGrade(rs.getInt("idGrade"));
                g.setValue(rs.getDouble("value"));
                g.setDescription(rs.getString("description"));
                g.setWeight(rs.getDouble("weight"));
                g.setRegisterDate(rs.getDate("registerDate"));
                g.setIdStudent(rs.getInt("idStudent"));
                g.setIdCourseSchedule(rs.getInt("idCourseSchedule"));
                grades.add(g);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return grades;
    }

    @Override
    public int insert(Grade g) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call insertGrade(?,?,?,?,?,?,?)}");
            cs.setInt(1, 1);
            cs.setDouble(2, g.getValue());
            cs.setString(3, g.getDescription());
            cs.setDouble(4, g.getWeight());
            cs.setDate(5, (Date) g.getRegisterDate());
            cs.setInt(6, g.getIdStudent());
            cs.setInt(7, g.getIdCourseSchedule());
            result= cs.executeUpdate();
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }

    @Override
    public int update(Grade g) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateGrade(?,?,?,?,?,?,?)}");
            cs.setInt(1, g.getIdGrade());
            cs.setDouble(2, g.getValue());
            cs.setString(3, g.getDescription());
            cs.setDouble(4, g.getWeight());
            cs.setDate(5, (Date) g.getRegisterDate());
            cs.setInt(6, g.getIdStudent());
            cs.setInt(7, g.getIdCourseSchedule());
            result= cs.executeUpdate();
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }

    @Override
    public int delete(Grade g) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteGrade(?)}");
            cs.setInt(1, g.getIdGrade());
            cs.setInt(2, 0);    
            cs.setDouble(4, 0);
            cs.setInt(6, 0);
            cs.setInt(7, 0);
            result= cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }
    
}
