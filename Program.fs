/// If you received help from anyone not me, or consulted any non-official documentation,
///   then document it here. If none used, write "N/A"

/// ATTR: TODO

module Program =
    /// <summary>Converts a temperature in Fahrenheit to Celcius</summary>
    /// <param name="f">The temperature in Fahrenheit</param>
    /// <returns>The temperature in Celcius</returns>
    let fToC f =
        5.0/ 9.0 * (f - 32.0)

    /// TODO: Complete and document
    let cToF c = 
        (9.0/5.0 * c) + 32.0
        

        

    [<EntryPoint>]
    let main _ =
        let tempC1 = -15.0
        let tempF1 = cToF tempC1
        printfn "%.2f in Celcius is %.2f" tempC1 tempF1
        
        let tempC2 = 10.0
        let tempF2 = cToF tempC2
        printfn "%.2f in Celcius is %.2f" tempC2 tempF2
        
        let tempC3 = 30.0
        let tempF3 = cToF tempC3
        printfn "%.2f in Celcius is %.2f" tempC3 tempF3

        0
