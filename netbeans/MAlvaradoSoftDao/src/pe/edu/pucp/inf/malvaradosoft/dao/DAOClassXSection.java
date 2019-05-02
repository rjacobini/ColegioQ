/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.ClassSection;

/**
 *
 * @author alulab14
 */
public interface DAOClassXSection {
    ArrayList <ClassSection> queryAll();
    int insert(ClassSection classXSection);
    int update(ClassSection classXSection);
    int delete(ClassSection classXSection);
}
