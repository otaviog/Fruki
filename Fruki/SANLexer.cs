// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g 2010-06-13 15:24:08


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class SANLexer : Lexer {
    public const int EXPONENT = 6;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int UNICODE_ESC = 13;
    public const int T__20 = 20;
    public const int OCTAL_ESC = 14;
    public const int CHAR = 11;
    public const int HEX_DIGIT = 12;
    public const int INT = 5;
    public const int FLOAT = 7;
    public const int ID = 4;
    public const int EOF = -1;
    public const int ROOT = 15;
    public const int T__30 = 30;
    public const int T__19 = 19;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__16 = 16;
    public const int T__33 = 33;
    public const int WS = 9;
    public const int ESC_SEQ = 10;
    public const int T__34 = 34;
    public const int T__18 = 18;
    public const int T__35 = 35;
    public const int T__17 = 17;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int COMMENT = 8;

    // delegates
    // delegators

    public SANLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SANLexer(ICharStream input)
		: this(input, null) {
    }
    public SANLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g";} 
    }

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:7:7: ( 'autonomus' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:7:9: 'autonomus'
            {
            	Match("autonomus"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:8:7: ( '{' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:8:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:9:7: ( '-' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:9:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:10:7: ( '*' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:10:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:11:7: ( ';' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:11:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:12:7: ( '}' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:12:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:13:7: ( 'event' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:13:9: 'event'
            {
            	Match("event"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:14:7: ( 'syn' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:14:9: 'syn'
            {
            	Match("syn"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:15:7: ( 'loc' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:15:9: 'loc'
            {
            	Match("loc"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:7: ( ':=' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:9: ':='
            {
            	Match(":="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:17:7: ( '<' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:17:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:18:7: ( '>' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:18:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:19:7: ( '=' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:19:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:7: ( '<=' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:7: ( '>=' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:22:7: ( '!>' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:22:9: '!>'
            {
            	Match("!>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:23:7: ( 'and' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:23:9: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:24:7: ( 'or' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:24:9: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:25:7: ( '+' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:25:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:7: ( '/' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:27:7: ( '(' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:27:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:28:7: ( ')' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:28:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:12:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:12:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:12:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:7: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:16:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
            int alt9 = 3;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
                    {
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:9: ( '0' .. '9' )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    		            EarlyExitException eee3 =
                    		                new EarlyExitException(3, input);
                    		            throw eee3;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	Match('.'); 
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:37: ( EXPONENT )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 'E' || LA5_0 == 'e') )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:20:37: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
                    {
                    	Match('.'); 
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:13: ( '0' .. '9' )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:25: ( EXPONENT )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 'E' || LA7_0 == 'e') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:21:25: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:22:9: ( '0' .. '9' )+ EXPONENT
                    {
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:22:9: ( '0' .. '9' )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:22:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt8 >= 1 ) goto loop8;
                    		            EarlyExitException eee8 =
                    		                new EarlyExitException(8, input);
                    		            throw eee8;
                    	    }
                    	    cnt8++;
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    	mEXPONENT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == '/') )
            {
                int LA13_1 = input.LA(2);

                if ( (LA13_1 == '/') )
                {
                    alt13 = 1;
                }
                else if ( (LA13_1 == '*') )
                {
                    alt13 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae_d13s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '\uFFFF')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:14: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:28: ( '\\r' )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == '\r') )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:26:28: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:27:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:27:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == '*') )
                    	    {
                    	        int LA12_1 = input.LA(2);

                    	        if ( (LA12_1 == '/') )
                    	        {
                    	            alt12 = 2;
                    	        }
                    	        else if ( ((LA12_1 >= '\u0000' && LA12_1 <= '.') || (LA12_1 >= '0' && LA12_1 <= '\uFFFF')) )
                    	        {
                    	            alt12 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= ')') || (LA12_0 >= '+' && LA12_0 <= '\uFFFF')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:27:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	Match("*/"); 

                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:30:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:30:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:37:5: ( '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\'' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:37:8: '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\''
            {
            	Match('\''); 
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:37:13: ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == '\\') )
            	{
            	    alt14 = 1;
            	}
            	else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '&') || (LA14_0 >= '(' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFF')) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:37:15: ESC_SEQ
            	        {
            	        	mESC_SEQ(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:37:25: ~ ( '\\'' | '\\\\' )
            	        {
            	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "EXPONENT"
    public void mEXPONENT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:41:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:41:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:41:22: ( '+' | '-' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == '+' || LA15_0 == '-') )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:41:33: ( '0' .. '9' )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= '0' && LA16_0 <= '9')) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:41:34: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:44:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:44:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "ESC_SEQ"
    public void mESC_SEQ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:48:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UNICODE_ESC | OCTAL_ESC )
            int alt17 = 3;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == '\\') )
            {
                switch ( input.LA(2) ) 
                {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                	{
                    alt17 = 1;
                    }
                    break;
                case 'u':
                	{
                    alt17 = 2;
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                	{
                    alt17 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d17s1 =
                	        new NoViableAltException("", 17, 1, input);

                	    throw nvae_d17s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:48:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    	Match('\\'); 
                    	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:49:9: UNICODE_ESC
                    {
                    	mUNICODE_ESC(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:50:9: OCTAL_ESC
                    {
                    	mOCTAL_ESC(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "OCTAL_ESC"
    public void mOCTAL_ESC() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt18 = 3;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == '\\') )
            {
                int LA18_1 = input.LA(2);

                if ( ((LA18_1 >= '0' && LA18_1 <= '3')) )
                {
                    int LA18_2 = input.LA(3);

                    if ( ((LA18_2 >= '0' && LA18_2 <= '7')) )
                    {
                        int LA18_5 = input.LA(4);

                        if ( ((LA18_5 >= '0' && LA18_5 <= '7')) )
                        {
                            alt18 = 1;
                        }
                        else 
                        {
                            alt18 = 2;}
                    }
                    else 
                    {
                        alt18 = 3;}
                }
                else if ( ((LA18_1 >= '4' && LA18_1 <= '7')) )
                {
                    int LA18_3 = input.LA(3);

                    if ( ((LA18_3 >= '0' && LA18_3 <= '7')) )
                    {
                        alt18 = 2;
                    }
                    else 
                    {
                        alt18 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:14: ( '0' .. '3' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:25: ( '0' .. '7' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:36: ( '0' .. '7' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:55:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:56:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:56:14: ( '0' .. '7' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:56:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:56:25: ( '0' .. '7' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:56:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:57:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:57:14: ( '0' .. '7' )
                    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:57:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OCTAL_ESC"

    // $ANTLR start "ROOT"
    public void mROOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ROOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:60:7: ( '@' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:60:10: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ROOT"

    // $ANTLR start "UNICODE_ESC"
    public void mUNICODE_ESC() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:64:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:64:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            	Match('\\'); 
            	Match('u'); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNICODE_ESC"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:8: ( T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | ID | INT | FLOAT | COMMENT | WS | CHAR | ROOT )
        int alt19 = 29;
        alt19 = dfa19.Predict(input);
        switch (alt19) 
        {
            case 1 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:10: T__16
                {
                	mT__16(); 

                }
                break;
            case 2 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:16: T__17
                {
                	mT__17(); 

                }
                break;
            case 3 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:22: T__18
                {
                	mT__18(); 

                }
                break;
            case 4 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:28: T__19
                {
                	mT__19(); 

                }
                break;
            case 5 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:34: T__20
                {
                	mT__20(); 

                }
                break;
            case 6 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:40: T__21
                {
                	mT__21(); 

                }
                break;
            case 7 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:46: T__22
                {
                	mT__22(); 

                }
                break;
            case 8 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:52: T__23
                {
                	mT__23(); 

                }
                break;
            case 9 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:58: T__24
                {
                	mT__24(); 

                }
                break;
            case 10 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:64: T__25
                {
                	mT__25(); 

                }
                break;
            case 11 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:70: T__26
                {
                	mT__26(); 

                }
                break;
            case 12 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:76: T__27
                {
                	mT__27(); 

                }
                break;
            case 13 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:82: T__28
                {
                	mT__28(); 

                }
                break;
            case 14 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:88: T__29
                {
                	mT__29(); 

                }
                break;
            case 15 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:94: T__30
                {
                	mT__30(); 

                }
                break;
            case 16 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:100: T__31
                {
                	mT__31(); 

                }
                break;
            case 17 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:106: T__32
                {
                	mT__32(); 

                }
                break;
            case 18 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:112: T__33
                {
                	mT__33(); 

                }
                break;
            case 19 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:118: T__34
                {
                	mT__34(); 

                }
                break;
            case 20 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:124: T__35
                {
                	mT__35(); 

                }
                break;
            case 21 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:130: T__36
                {
                	mT__36(); 

                }
                break;
            case 22 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:136: T__37
                {
                	mT__37(); 

                }
                break;
            case 23 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:142: ID
                {
                	mID(); 

                }
                break;
            case 24 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:145: INT
                {
                	mINT(); 

                }
                break;
            case 25 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:149: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 26 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:155: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 27 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:163: WS
                {
                	mWS(); 

                }
                break;
            case 28 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:166: CHAR
                {
                	mCHAR(); 

                }
                break;
            case 29 :
                // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:1:171: ROOT
                {
                	mROOT(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
    protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	    this.dfa19 = new DFA19(this);
	}

    const string DFA9_eotS =
        "\x05\uffff";
    const string DFA9_eofS =
        "\x05\uffff";
    const string DFA9_minS =
        "\x02\x2e\x03\uffff";
    const string DFA9_maxS =
        "\x01\x39\x01\x65\x03\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\x03";
    const string DFA9_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x03\x01\uffff\x0a\x01\x0b\uffff\x01\x04\x1f\uffff\x01"+
            "\x04",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "19:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; }
        }

    }

    const string DFA19_eotS =
        "\x01\uffff\x01\x14\x05\uffff\x03\x14\x01\uffff\x01\x20\x01\x22"+
        "\x02\uffff\x01\x14\x01\uffff\x01\x25\x03\uffff\x01\x26\x04\uffff"+
        "\x05\x14\x04\uffff\x01\x2c\x03\uffff\x01\x14\x01\x2e\x01\x14\x01"+
        "\x30\x01\x31\x01\uffff\x01\x14\x01\uffff\x01\x14\x02\uffff\x01\x14"+
        "\x01\x35\x01\x14\x01\uffff\x02\x14\x01\x39\x01\uffff";
    const string DFA19_eofS =
        "\x3a\uffff";
    const string DFA19_minS =
        "\x01\x09\x01\x6e\x05\uffff\x01\x76\x01\x79\x01\x6f\x01\uffff\x02"+
        "\x3d\x02\uffff\x01\x72\x01\uffff\x01\x2a\x03\uffff\x01\x2e\x04\uffff"+
        "\x01\x74\x01\x64\x01\x65\x01\x6e\x01\x63\x04\uffff\x01\x30\x03\uffff"+
        "\x01\x6f\x01\x30\x01\x6e\x02\x30\x01\uffff\x01\x6e\x01\uffff\x01"+
        "\x74\x02\uffff\x01\x6f\x01\x30\x01\x6d\x01\uffff\x01\x75\x01\x73"+
        "\x01\x30\x01\uffff";
    const string DFA19_maxS =
        "\x01\x7d\x01\x75\x05\uffff\x01\x76\x01\x79\x01\x6f\x01\uffff\x02"+
        "\x3d\x02\uffff\x01\x72\x01\uffff\x01\x2f\x03\uffff\x01\x65\x04\uffff"+
        "\x01\x74\x01\x64\x01\x65\x01\x6e\x01\x63\x04\uffff\x01\x7a\x03\uffff"+
        "\x01\x6f\x01\x7a\x01\x6e\x02\x7a\x01\uffff\x01\x6e\x01\uffff\x01"+
        "\x74\x02\uffff\x01\x6f\x01\x7a\x01\x6d\x01\uffff\x01\x75\x01\x73"+
        "\x01\x7a\x01\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x03\uffff\x01"+
        "\x0a\x02\uffff\x01\x0d\x01\x10\x01\uffff\x01\x13\x01\uffff\x01\x15"+
        "\x01\x16\x01\x17\x01\uffff\x01\x19\x01\x1b\x01\x1c\x01\x1d\x05\uffff"+
        "\x01\x0e\x01\x0b\x01\x0f\x01\x0c\x01\uffff\x01\x1a\x01\x14\x01\x18"+
        "\x05\uffff\x01\x12\x01\uffff\x01\x11\x01\uffff\x01\x08\x01\x09\x03"+
        "\uffff\x01\x07\x03\uffff\x01\x01";
    const string DFA19_specialS =
        "\x3a\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x02\x17\x02\uffff\x01\x17\x12\uffff\x01\x17\x01\x0e\x05\uffff"+
            "\x01\x18\x01\x12\x01\x13\x01\x04\x01\x10\x01\uffff\x01\x03\x01"+
            "\x16\x01\x11\x0a\x15\x01\x0a\x01\x05\x01\x0b\x01\x0d\x01\x0c"+
            "\x01\uffff\x01\x19\x1a\x14\x04\uffff\x01\x14\x01\uffff\x01\x01"+
            "\x03\x14\x01\x07\x06\x14\x01\x09\x02\x14\x01\x0f\x03\x14\x01"+
            "\x08\x07\x14\x01\x02\x01\uffff\x01\x06",
            "\x01\x1b\x06\uffff\x01\x1a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1c",
            "\x01\x1d",
            "\x01\x1e",
            "",
            "\x01\x1f",
            "\x01\x21",
            "",
            "",
            "\x01\x23",
            "",
            "\x01\x24\x04\uffff\x01\x24",
            "",
            "",
            "",
            "\x01\x16\x01\uffff\x0a\x15\x0b\uffff\x01\x16\x1f\uffff\x01"+
            "\x16",
            "",
            "",
            "",
            "",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x2b",
            "",
            "",
            "",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            "",
            "",
            "\x01\x2d",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x2f",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            "\x01\x32",
            "",
            "\x01\x33",
            "",
            "",
            "\x01\x34",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x36",
            "",
            "\x01\x37",
            "\x01\x38",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | ID | INT | FLOAT | COMMENT | WS | CHAR | ROOT );"; }
        }

    }

 
    
}
