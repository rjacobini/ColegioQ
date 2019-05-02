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
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.ClassSection;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Course;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.CourseXSchedule;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Schedule;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOCourseXSchedule;

/**
 *
 * @author alulab14
 */
public class MySQLCoursexSchedule implements DAOCourseXSchedule {

    @Override
    public ArrayList<CourseXSchedule> queryAll() {
         ArrayList<CourseXSchedule> courseXSchedules = new ArrayList<CourseXSchedule>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM SchedulexCourse";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                CourseXSchedule cxs = new CourseXSchedule();
                cxs.setIdCourseSchedule(rs.getInt("idCourseSchedule"));
                cxs.setIdClassSection(rs.getInt("idClassSection"));
                cxs.setSchedule(new Schedule());
                cxs.getSchedule().setIdSchedule(rs.getInt("idSchedule"));
                cxs.setCourse(new Course());
                cxs.getCourse().setId(rs.getInt("idCourse"));
                cxs.setCodTeacher(rs.getInt("idTeacher"));
                courseXSchedules.add(cxs);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return courseXSchedules;
    }

    @Override
    public int insert(CourseXSchedule coursexSchedule) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("" + "{call insertSchedulexCourse(?,?,?,?)}");
            cs.setInt(1, 1);
            cs.setInt(2,coursexSchedule.getIdClassSection());
            cs.setInt(3,coursexSchedule.getSchedule().getIdSchedule());
            cs.setInt(4,coursexSchedule.getCourse().getId());
            cs.setInt(5,coursexSchedule.getCodTeacher());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;
    }

    @Override
    public int update(CourseXSchedule coursexSchedule) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateSchedulexCourse(?,?,?,?,?)}");
            cs.setInt(1,coursexSchedule.getIdCourseSchedule());
            cs.setInt(2,coursexSchedule.getIdClassSection());
            cs.setInt(3,coursexSchedule.getSchedule().getIdSchedule());
            cs.setInt(4,coursexSchedule.getCourse().getId());
            cs.setInt(5,coursexSchedule.getCodTeacher());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int delete(CourseXSchedule coursexSchedule) {
      int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteSchedulexCourse(?)}");
            cs.setInt(1,coursexSchedule.getIdCourseSchedule());          
            result= cs.executeUpdate();
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return result;  
    }
    
}
