namespace QRN {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Convert;    

    operation GenerateRandomBit() : Result {
        // Allocate a qubit.
        using (q = Qubit()) {
            // Put the qubit to superposition.
            H(q);
            // It now has a 50% chance of being measured 0 or 1.
            // Measure the qubit value.
            return MResetZ(q);
        }
    }

    operation SampleRandomNumberInRange( max : Int) : Int {
        mutable output = 0; 
        repeat {
            mutable bits = new Result[0]; 
            for (idxBit in 1..BitSizeI(max) ) {
                set bits += [GenerateRandomBit()]; 
            }
            set output = ResultArrayAsInt(bits);
        } until (output <= max );
        return output;
    }

    
    @EntryPoint()
    operation SampleRandomNumber() : Int {
        let min = 10000;
        let max = 99999;
        Message($"Sampling a random number between {min} and {max}: ");
        mutable output2 = 0; 
        repeat {
        set output2= SampleRandomNumberInRange( max);

        } until (output2 >= min ) ;
        return output2 ;
    }
}


