/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.inf.malvaradosoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.inf.MAlvaradoSoft.model.bean.ClassXSection;

/**
 *
 * @author alulab14
 */
public interface DAOClassXSection {
    ArrayList <ClassXSection> queryAll();
    int insert(ClassXSection classXSection);
    int update(ClassXSection classXSection);
    int delete(ClassXSection classXSection);
}
