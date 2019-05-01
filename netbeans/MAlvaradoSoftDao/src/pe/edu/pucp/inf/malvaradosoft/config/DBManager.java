/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.config;

import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.security.AnyTypePermission;
import java.io.FileReader;

/**
 *
 * @author alulab14
 */
public class DBManager {
    private String url;
    private String password;
    private String user;
    private static DBManager dbManager;

    public DBManager(String url, String password, String user) {
        this.url = url;
        this.password = password;
        this.user = user;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getUser() {
        return user;
    }

    public void setUser(String user) {
        this.user = user;
    }

    public static DBManager getDbManager() {
        if(dbManager == null){
            XStream xstream = new XStream();
            xstream.addPermission(AnyTypePermission.ANY);
            FileReader reader;
            try{
                reader = new FileReader("config.xml");
                ConnectionParameters connParam= (ConnectionParameters)xstream.fromXML(reader);
                String url = connParam.getUrl();
                String user = connParam.getUser();
                String password = connParam.getPassword();
                
                dbManager = new DBManager(url, password, user);
                Class.forName("com.mysql.cj.jdbc.Driver");
                System.out.println("Se ha registrado el Driver");
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return dbManager;
    }

    public void setDbManager(DBManager dbManager) {
        this.dbManager = dbManager;
    }
    
    
}
