/*compilying: $valac --pkg gtk+-2.0 file_name.vala*/
/*executing: $./file_name*/

using GLib; 
using Gtk;

public class test{

	public static int main (string[] args) 
	{ 
		Gtk.init(ref args);
	
		var win = new MainWindow();
		win.show_all();
		
		Gtk.main();
		 return 0; 
	} 
} 

public class MainWindow : Gtk.Window
{
	Gtk.Button btnOk;	
	public MainWindow()
	{
		this.destroy.connect(Gtk.main_quit);
		
		btnOk = new Gtk.Button();
		btnOk.label = "Press Me!";
		btnOk.clicked.connect(btnOk_clicked);
		this.add(btnOk);
	}

	private void btnOk_clicked()
	{
		stdout.printf("btnOk_clicked!!!\n");
	}
}
