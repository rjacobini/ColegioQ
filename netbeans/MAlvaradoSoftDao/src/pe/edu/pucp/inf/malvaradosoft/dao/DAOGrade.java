/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.Grade;

/**
 *
 * @author alulab14
 */
public interface DAOGrade {
    ArrayList <Grade> queryAll();
    int insert(Grade g);
    int update();
    int delete();
}
