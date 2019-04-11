package pe.edu.pucp.IEPMariaAlvarado.model.bean;
public class Principal extends Person{
	private int codPrincipal;
	private int codRepository;

    public int getCodPrincipal() {
        return codPrincipal;
    }

    public void setCodPrincipal(int codPrincipal) {
        this.codPrincipal = codPrincipal;
    }

    public int getCodRepository() {
        return codRepository;
    }

    public void setCodRepository(int codRepository) {
        this.codRepository = codRepository;
    }
        
}