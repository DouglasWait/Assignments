
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JFrame;
import javax.swing.JTextField;
import java.io.*;
import java.io.PrintWriter;

public class KeyListener {
 
    public static void main(String[] argv) throws Exception {
 
  
  JTextField textField = new JTextField();
 
  textField.addKeyListener(new MKeyListener());
 
  JFrame jframe = new JFrame();
 
  jframe.add(textField);
 
  jframe.setSize(400, 350);
 
  jframe.setVisible(true);//.62
 
    }

	
 
	}
	

 class MKeyListener extends KeyAdapter {
	String textWhole="";
 
 String filePath ="C:\\Users\\dwwai\\Desktop\\ITRW\\ITRW316\\KeyboardListener\\KeyInput.txt";
    @Override
    public void keyPressed(KeyEvent event)
	{
	
	char ch = event.getKeyChar();
	System.out.println(event.getKeyChar());
	
	textWhole=textWhole+ch;
	
	String appendthetext=""+ch;
	
	if(textWhole.contains("save"))
	{
	textWhole=textWhole.substring(0,(textWhole.length()-4));
	appendUsingPrintWriter(filePath,textWhole);
	textWhole="";
	}
	

  
    }
	public void appendUsingPrintWriter(String filePath, String text) {
		File file = new File(filePath);
		FileWriter fr = null;
		BufferedWriter br = null;
		PrintWriter pr = null;
		try {
			
			fr = new FileWriter(file, true);
			br = new BufferedWriter(fr);
			pr = new PrintWriter(br);
			pr.println(text);
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			try {
				pr.close();
				br.close();
				fr.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
}
}
