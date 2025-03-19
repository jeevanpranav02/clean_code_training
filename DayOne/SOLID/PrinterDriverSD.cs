public class PrinterDriver {
    private Printer printer;
    private IInputDevice device; 

    public PrinterDriver(Printer printer, IInputDevice device) {
        this.printer = printer;
        this.device = device;
    }

    public void Print() {
        while(device.IsEndOfData() == false) {
            printer.Print(device.ReadPage());
        }
    }
}

public interface IInputDevice {
    public buffer GetData();
    public bool IsEndOfData();
}

public class File : IInputDevice {
    private string path;
    private StreamReader reader;

    public File(string path) {
        this.path = path;
        reader = new StreamReader(path);
    }

    public buffer GetData() {
        return reader.ReadLine();
    }

    public bool IsEndOfData() {
        return reader.EndOfStream;
    }
}

public class ScannerDevice : IInputDevice {
    private Scanner scanner;

    public ScannerDevice() {
        scanner = new Scanner();
    }

    public buffer GetData() {
        return scanner.Scan();
    }

    public bool IsEndOfData() {
        return scanner.IsEndOfData();
    }
}

public class FaxDevice : IInputDevice {
    private Fax fax;

    public Fax() {
        fax = new Fax();
    }

    public buffer GetData() {
        return fax.Receive();
    }

    public bool IsEndOfData() {
        return fax.IsEndOfData();
    }
}
