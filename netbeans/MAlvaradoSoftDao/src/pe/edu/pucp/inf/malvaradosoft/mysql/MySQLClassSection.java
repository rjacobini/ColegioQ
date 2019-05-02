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
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Auxiliar;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.ClassSection;
import pe.edu.pucp.inf.malvaradosoft.config.DBManager;
import pe.edu.pucp.inf.malvaradosoft.dao.DAOClassXSection;

/**
 *
 * @author alulab14
 */
public class MySQLClassSection implements DAOClassXSection{

    @Override
    public ArrayList<ClassSection> queryAll() {
        ArrayList<ClassSection> classesSection = new ArrayList<ClassSection>();
        try{
            DBManager dbManager= DBManager.getDbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT * FROM ClassSection";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next()){
                ClassSection cxs = new ClassSection();
                cxs.setId(rs.getInt("idSection"));
                cxs.setTotal(rs.getInt("total"));
                cxs.setName(rs.getString("name"));
                classesSection.add(cxs);
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    return classesSection;
    }

    @Override
    public int insert(ClassSection classSection) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call insertClassSection(?,?)}");
            cs.setInt(1, classSection.getTotal() );
            cs.setString(2, classSection.getName() );
            result = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int update(ClassSection classSection) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call insertClassSection(?,?)}");
            cs.setInt(1, classSection.getTotal() );
            cs.setString(2, classSection.getName() );
            result = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int delete(ClassSection classSection) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getDbManager();
            Connection con = DriverManager.getConnection(
            dbManager.getUrl(), 
            dbManager.getUser(), 
            dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call deleteClassSection(?)}");
            cs.setInt(1, classSection.getId() );
            
            result = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
}
