
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action openAction;
	private global::Gtk.Action ArchivoAction;
	private global::Gtk.Action saveAsAction;
	private global::Gtk.Action newAction;
	private global::Gtk.Action saveAction2;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action newAction1;
	private global::Gtk.Action openAction1;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action saveAsAction1;
	private global::Gtk.Action quitAction1;
	private global::Gtk.Action revertToSavedAction;
	private global::Gtk.Action newAction2;
	private global::Gtk.Action openAction2;
	private global::Gtk.Action saveAction3;
	private global::Gtk.Action saveAsAction2;
	private global::Gtk.Action quitAction2;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textView;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
		w1.Add (this.openAction, null);
		this.ArchivoAction = new global::Gtk.Action ("ArchivoAction", global::Mono.Unix.Catalog.GetString ("Archivo"), null, null);
		this.ArchivoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Archivo");
		w1.Add (this.ArchivoAction, null);
		this.saveAsAction = new global::Gtk.Action ("saveAsAction", global::Mono.Unix.Catalog.GetString ("Guardar co_mo"), null, "gtk-save-as");
		this.saveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Guardar co_mo");
		w1.Add (this.saveAsAction, null);
		this.newAction = new global::Gtk.Action ("newAction", global::Mono.Unix.Catalog.GetString ("_Nuevo"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Nuevo");
		w1.Add (this.newAction, null);
		this.saveAction2 = new global::Gtk.Action ("saveAction2", global::Mono.Unix.Catalog.GetString ("_Guardar"), null, "gtk-save");
		this.saveAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Guardar");
		w1.Add (this.saveAction2, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("_Salir"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Salir");
		w1.Add (this.quitAction, null);
		this.newAction1 = new global::Gtk.Action ("newAction1", global::Mono.Unix.Catalog.GetString ("_Nuevo"), null, "gtk-new");
		this.newAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Nuevo");
		w1.Add (this.newAction1, null);
		this.openAction1 = new global::Gtk.Action ("openAction1", global::Mono.Unix.Catalog.GetString ("_Abrir"), null, "gtk-open");
		this.openAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Abrir");
		w1.Add (this.openAction1, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("_Guardar"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Guardar");
		w1.Add (this.saveAction, null);
		this.saveAsAction1 = new global::Gtk.Action ("saveAsAction1", global::Mono.Unix.Catalog.GetString ("Guardar co_mo"), null, "gtk-save-as");
		this.saveAsAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Guardar co_mo");
		w1.Add (this.saveAsAction1, null);
		this.quitAction1 = new global::Gtk.Action ("quitAction1", global::Mono.Unix.Catalog.GetString ("_Salir"), null, "gtk-quit");
		this.quitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Salir");
		w1.Add (this.quitAction1, null);
		this.revertToSavedAction = new global::Gtk.Action ("revertToSavedAction", null, null, "gtk-revert-to-saved");
		w1.Add (this.revertToSavedAction, null);
		this.newAction2 = new global::Gtk.Action ("newAction2", global::Mono.Unix.Catalog.GetString ("_Nuevo"), null, "gtk-new");
		this.newAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Nuevo");
		w1.Add (this.newAction2, null);
		this.openAction2 = new global::Gtk.Action ("openAction2", global::Mono.Unix.Catalog.GetString ("_Abrir"), null, "gtk-open");
		this.openAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Abrir");
		w1.Add (this.openAction2, null);
		this.saveAction3 = new global::Gtk.Action ("saveAction3", global::Mono.Unix.Catalog.GetString ("_Guardar"), null, "gtk-save");
		this.saveAction3.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Guardar");
		w1.Add (this.saveAction3, null);
		this.saveAsAction2 = new global::Gtk.Action ("saveAsAction2", global::Mono.Unix.Catalog.GetString ("Guardar co_mo"), null, "gtk-save-as");
		this.saveAsAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("Guardar co_mo");
		w1.Add (this.saveAsAction2, null);
		this.quitAction2 = new global::Gtk.Action ("quitAction2", global::Mono.Unix.Catalog.GetString ("_Salir"), null, "gtk-quit");
		this.quitAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Salir");
		w1.Add (this.quitAction2, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='ArchivoAction' action='ArchivoAction'><menuitem name='newAction2' action='newAction2'/><menuitem name='openAction2' action='openAction2'/><menuitem name='saveAction3' action='saveAction3'/><menuitem name='saveAsAction2' action='saveAsAction2'/><separator/><menuitem name='quitAction2' action='quitAction2'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='newAction' action='newAction'/><toolitem name='openAction' action='openAction'/><toolitem name='saveAction2' action='saveAction2'/><toolitem name='saveAsAction' action='saveAsAction'/><toolitem name='quitAction' action='quitAction'/><toolitem name='revertToSavedAction' action='revertToSavedAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textView = new global::Gtk.TextView ();
		this.textView.CanFocus = true;
		this.textView.Name = "textView";
		this.GtkScrolledWindow.Add (this.textView);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w5.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 418;
		this.DefaultHeight = 304;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.newAction.Activated += new global::System.EventHandler (this.OnNewActionActivated);
	}
}
