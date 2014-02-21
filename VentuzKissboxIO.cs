using System;
using Ventuz.Kernel;
using System.Text;


public class Script : ScriptBase, System.IDisposable
{
    
	// This member is used by the Validate() method to indicate
	// whether the Generate() method should return true or false
	// during its next execution.
	private bool changed;
    
	
	private bool[][] States = new bool[8][];
	
	// message structure 
	private struct Message{
		public byte COMMAND;
		public byte SLOT;
		public byte INPUT;
		public bool STATE;
	
		public static implicit operator Message(byte[] b) {
			return new Message() {		
					COMMAND = b[0],
					SLOT = b[1],
					INPUT = b[2],
					STATE = Convert.ToBoolean(b[3])
					};
		}	
	}
	
	private Encoding enc;
	
	
	// This Method is called if the component is loaded/created.
	public Script()
	{
		// Note: Accessing input or output properties from this method
		// will have no effect as they have not been allocated yet.
		for (int i = 0; i <= 7; i++){
			States[i] = new bool[]{false,false,false,false,false,false,false,false};
		}
		
		enc = Encoding.GetEncoding("ISO-8859-1");
		
	}
    
	// This Method is called if the component is unloaded/disposed
	public virtual void Dispose()
	{
	}
    
	// This Method is called if an input property has changed its value
	public override void Validate()
	{
		// Remember: set changed to true if any of the output 
		// properties has been changed, see Generate()
		
		byte[] b = enc.GetBytes(response);
		
		Message m = b;
		
		States[m.SLOT][m.INPUT] = m.STATE;
		
		Slot1 = States[0];
		Slot2 = States[1];
		Slot3 = States[2];
		Slot4 = States[3];
		Slot5 = States[4];
		Slot6 = States[5];
		Slot7 = States[6];
		Slot8 = States[7];
		
		
		changed = true;
		
		
	}
    
	// This Method is called every time before a frame is rendered.
	// Return value: if true, Ventuz will notify all nodes bound to this
	//               script node that one of the script's outputs has a
	//               new value and they therefore need to validate. For
	//               performance reasons, only return true if output
	//               values really have been changed.
	public override bool Generate()
	{
		if (changed)
		{
			changed = false;
			return true;
		}

		return false;
	}
}
