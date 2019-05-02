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
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Workshop;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOWorkshop;

/**
 *
 * @author alulab14
 */
public class MySQLWorkshop implements DAOWorkshop{

    @Override
    public ArrayList<Workshop> queryAll() {
        ArrayList<Workshop> workshops = new ArrayList<Workshop>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM Workshop";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                Workshop w = new Workshop();
                w.setCodWorkshop(rs.getInt("codWorkshop"));           
                workshops.add(w);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return workshops;
        
    }

    @Override
    public int insert(Workshop workshop) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("" + "{call insertWorkshop(?,?,?,?,?)}");
            cs.setInt(1, workshop.getCodWorkshop());
            cs.setString(2, workshop.getDescription());
            cs.setInt(3, workshop.getCodTeacher());
            cs.setInt(4, workshop.getCodCourse());
            cs.setInt(5, workshop.getIdSchedule());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }

    @Override
    public int update(Workshop workshop) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call updateWorkshop(?,?,?,?,?)}");
            cs.setInt(1, workshop.getCodWorkshop());
            cs.setString(2, workshop.getDescription());
            cs.setInt(3, workshop.getCodTeacher());
            cs.setInt(4, workshop.getCodCourse());
            cs.setInt(5, workshop.getIdSchedule());            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }

    @Override
    public int delete(Workshop workshop) {
        int result= 0;
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(""
                    + "{call deleteWorkshop(?)}");
            cs.setInt(1, workshop.getCodWorkshop());
            result= cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
    }
    
}
