package szamforditva;

import java.io.*;
import java.util.*;

public class Szamforditva {
    public static void main(String[] args) {
               
        Scanner scanner = null;
        PrintStream ps = null;
        String seged;
        int szam;
        try {
            
            scanner = new Scanner(new File("szamok.txt"));
            ps = new PrintStream("masodik.txt");
            while(scanner.hasNextLine()){
                //System.out.println(scanner.nextLine());
                //szamok.add(scanner.nextLine());
                seged = scanner.nextLine();
                szam = Integer.parseInt(seged);
                char[] szamok = new char[seged.length()];
                for (int i = 0; i < seged.length(); i++) {
                    
                    szamok[i] = seged.charAt(i);
                    
                    //System.out.print(szamok[i]);
                }
                String szo = "";
                for (int i = szamok.length-1; i > -1; i--) {
                    szo = szo + szamok[i];
                    
                }
                System.out.println(szo);
                ps.println(szo);
                
                //System.out.println(marad);
            }
            
            
        }catch (IOException e) {
            System.err.println(e);
        } finally {
            
            if (scanner != null){
                scanner.close();
            }
        }
        
        
        
    }
    
}

        
       
            