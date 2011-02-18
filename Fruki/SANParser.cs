// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g 2010-06-13 15:24:08


using Fruki;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class SANParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ID", 
		"INT", 
		"EXPONENT", 
		"FLOAT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"CHAR", 
		"HEX_DIGIT", 
		"UNICODE_ESC", 
		"OCTAL_ESC", 
		"ROOT", 
		"'autonomus'", 
		"'{'", 
		"'-'", 
		"'*'", 
		"';'", 
		"'}'", 
		"'event'", 
		"'syn'", 
		"'loc'", 
		"':='", 
		"'<'", 
		"'>'", 
		"'='", 
		"'<='", 
		"'>='", 
		"'!>'", 
		"'and'", 
		"'or'", 
		"'+'", 
		"'/'", 
		"'('", 
		"')'"
    };

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
    public const int FLOAT = 7;
    public const int INT = 5;
    public const int ID = 4;
    public const int EOF = -1;
    public const int ROOT = 15;
    public const int T__19 = 19;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int ESC_SEQ = 10;
    public const int WS = 9;
    public const int T__33 = 33;
    public const int T__16 = 16;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__18 = 18;
    public const int T__36 = 36;
    public const int T__17 = 17;
    public const int T__37 = 37;
    public const int COMMENT = 8;

    // delegates
    // delegators



        public SANParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SANParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        

    override public string[] TokenNames {
		get { return SANParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g"; }
    }



    // $ANTLR start "start"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:1: start[SAN san] : (aut= automonus )+ (ev= eventrl )+ ;
    public void start(SAN san) // throws RecognitionException [1]
    {   
        Autonomus aut = null;

        Event ev = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:18: ( (aut= automonus )+ (ev= eventrl )+ )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:20: (aut= automonus )+ (ev= eventrl )+
            {
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:20: (aut= automonus )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 16) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:21: aut= automonus
            			    {
            			    	PushFollow(FOLLOW_automonus_in_start559);
            			    	aut = automonus();
            			    	state.followingStackPointer--;

            			    	 san.AddAutonomus(aut); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:64: (ev= eventrl )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 22) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:67:65: ev= eventrl
            			    {
            			    	PushFollow(FOLLOW_eventrl_in_start568);
            			    	ev = eventrl();
            			    	state.followingStackPointer--;

            			    	 san.AddEvent(ev); 

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

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "start"


    // $ANTLR start "automonus"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:69:1: automonus returns [Autonomus aut] : 'autonomus' name= ID '{' (fromName= INT '-' ev= ID ( '*' tax= FLOAT )? '-' toName= INT ';' )+ '}' ;
    public Autonomus automonus() // throws RecognitionException [1]
    {   
        Autonomus aut = null;

        IToken name = null;
        IToken fromName = null;
        IToken ev = null;
        IToken tax = null;
        IToken toName = null;

        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:69:35: ( 'autonomus' name= ID '{' (fromName= INT '-' ev= ID ( '*' tax= FLOAT )? '-' toName= INT ';' )+ '}' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:69:37: 'autonomus' name= ID '{' (fromName= INT '-' ev= ID ( '*' tax= FLOAT )? '-' toName= INT ';' )+ '}'
            {
            	Match(input,16,FOLLOW_16_in_automonus587); 
            	name=(IToken)Match(input,ID,FOLLOW_ID_in_automonus591); 
            	 
            			aut = new Autonomus(name.Text); 
            		
            	Match(input,17,FOLLOW_17_in_automonus599); 
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:73:6: (fromName= INT '-' ev= ID ( '*' tax= FLOAT )? '-' toName= INT ';' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == INT) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:73:7: fromName= INT '-' ev= ID ( '*' tax= FLOAT )? '-' toName= INT ';'
            			    {
            			    	fromName=(IToken)Match(input,INT,FOLLOW_INT_in_automonus604); 
            			    	Match(input,18,FOLLOW_18_in_automonus606); 
            			    	ev=(IToken)Match(input,ID,FOLLOW_ID_in_automonus610); 
            			    	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:73:30: ( '*' tax= FLOAT )?
            			    	int alt3 = 2;
            			    	int LA3_0 = input.LA(1);

            			    	if ( (LA3_0 == 19) )
            			    	{
            			    	    alt3 = 1;
            			    	}
            			    	switch (alt3) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:73:31: '*' tax= FLOAT
            			    	        {
            			    	        	Match(input,19,FOLLOW_19_in_automonus613); 
            			    	        	tax=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_automonus617); 

            			    	        }
            			    	        break;

            			    	}

            			    	Match(input,18,FOLLOW_18_in_automonus622); 
            			    	toName=(IToken)Match(input,INT,FOLLOW_INT_in_automonus626); 
            			    	Match(input,20,FOLLOW_20_in_automonus628); 
            			    			
            			    			float ratio = (tax != null) ? float.Parse(tax.Text, System.Globalization.CultureInfo.InvariantCulture) : 1.0f;
            			    			aut.AddEdge(ev.Text, Int32.Parse(fromName.Text), Int32.Parse(toName.Text), 
            			    				ratio);	
            			    			tax = null;	

            			    		

            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	Match(input,21,FOLLOW_21_in_automonus637); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return aut;
    }
    // $ANTLR end "automonus"


    // $ANTLR start "eventrl"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:84:1: eventrl returns [Event ev] : 'event' name= ID opt= ( 'syn' | 'loc' ) ':=' ex= expr ';' ;
    public Event eventrl() // throws RecognitionException [1]
    {   
        Event ev = null;

        IToken name = null;
        IToken opt = null;
        Expr ex = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:84:27: ( 'event' name= ID opt= ( 'syn' | 'loc' ) ':=' ex= expr ';' )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:84:29: 'event' name= ID opt= ( 'syn' | 'loc' ) ':=' ex= expr ';'
            {
            	Match(input,22,FOLLOW_22_in_eventrl651); 
            	name=(IToken)Match(input,ID,FOLLOW_ID_in_eventrl655); 
            	opt = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 23 && input.LA(1) <= 24) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	Match(input,25,FOLLOW_25_in_eventrl667); 
            	PushFollow(FOLLOW_expr_in_eventrl671);
            	ex = expr();
            	state.followingStackPointer--;

            	Match(input,20,FOLLOW_20_in_eventrl673); 

            			Event.EventType tp = (opt.Text == "syn") ? Event.EventType.SYN : Event.EventType.LOC;
            			ev = new Event(name.Text, tp, ex);
            		

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ev;
    }
    // $ANTLR end "eventrl"


    // $ANTLR start "expr"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:91:1: expr returns [Expr rexpr] : left= mathexpr (s= ( '<' | '>' | '=' | '<=' | '>=' | '!>' | 'and' | 'or' ) right= expr )* ;
    public Expr expr() // throws RecognitionException [1]
    {   
        Expr rexpr = null;

        IToken s = null;
        Expr left = null;

        Expr right = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:92:2: (left= mathexpr (s= ( '<' | '>' | '=' | '<=' | '>=' | '!>' | 'and' | 'or' ) right= expr )* )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:92:4: left= mathexpr (s= ( '<' | '>' | '=' | '<=' | '>=' | '!>' | 'and' | 'or' ) right= expr )*
            {
            	PushFollow(FOLLOW_mathexpr_in_expr697);
            	left = mathexpr();
            	state.followingStackPointer--;


            			rexpr = left;
            		
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:96:2: (s= ( '<' | '>' | '=' | '<=' | '>=' | '!>' | 'and' | 'or' ) right= expr )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= 26 && LA5_0 <= 33)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:96:3: s= ( '<' | '>' | '=' | '<=' | '>=' | '!>' | 'and' | 'or' ) right= expr
            			    {
            			    	s = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 26 && input.LA(1) <= 33) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_expr_in_expr728);
            			    	right = expr();
            			    	state.followingStackPointer--;

            			    			
            			    			rexpr = new LogicExpr(s.Text, left, right);
            			    			left = rexpr;
            			    		

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return rexpr;
    }
    // $ANTLR end "expr"


    // $ANTLR start "mathexpr"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:104:1: mathexpr returns [Expr arit] : left= term (s= ( '+' | '-' ) right= term )* ;
    public Expr mathexpr() // throws RecognitionException [1]
    {   
        Expr arit = null;

        IToken s = null;
        Expr left = null;

        Expr right = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:105:2: (left= term (s= ( '+' | '-' ) right= term )* )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:105:4: left= term (s= ( '+' | '-' ) right= term )*
            {
            	PushFollow(FOLLOW_term_in_mathexpr753);
            	left = term();
            	state.followingStackPointer--;

            	 
            			arit = left;	
            		
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:109:2: (s= ( '+' | '-' ) right= term )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == 18 || LA6_0 == 34) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:109:3: s= ( '+' | '-' ) right= term
            			    {
            			    	s = (IToken)input.LT(1);
            			    	if ( input.LA(1) == 18 || input.LA(1) == 34 ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_term_in_mathexpr774);
            			    	right = term();
            			    	state.followingStackPointer--;


            			    			arit = new AritExpr(s.Text[0], left, right);
            			    			left = arit;		
            			    		

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return arit;
    }
    // $ANTLR end "mathexpr"


    // $ANTLR start "term"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:117:1: term returns [Expr arit] : left= factor (s= ( '*' | '/' ) right= factor )* ;
    public Expr term() // throws RecognitionException [1]
    {   
        Expr arit = null;

        IToken s = null;
        Expr left = null;

        Expr right = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:118:2: (left= factor (s= ( '*' | '/' ) right= factor )* )
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:118:4: left= factor (s= ( '*' | '/' ) right= factor )*
            {
            	PushFollow(FOLLOW_factor_in_term799);
            	left = factor();
            	state.followingStackPointer--;


            			arit = left;
            		
            	// C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:122:2: (s= ( '*' | '/' ) right= factor )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 19 || LA7_0 == 35) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:122:3: s= ( '*' | '/' ) right= factor
            			    {
            			    	s = (IToken)input.LT(1);
            			    	if ( input.LA(1) == 19 || input.LA(1) == 35 ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_factor_in_term816);
            			    	right = factor();
            			    	state.followingStackPointer--;


            			    			arit = new AritExpr(s.Text[0], left, right);
            			    			left = arit;
            			    		

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return arit;
    }
    // $ANTLR end "term"


    // $ANTLR start "factor"
    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:130:1: factor returns [Expr val] : (f= FLOAT | id= ID | i= INT | '(' intern= expr ')' );
    public Expr factor() // throws RecognitionException [1]
    {   
        Expr val = null;

        IToken f = null;
        IToken id = null;
        IToken i = null;
        Expr intern = null;


        try 
    	{
            // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:131:2: (f= FLOAT | id= ID | i= INT | '(' intern= expr ')' )
            int alt8 = 4;
            switch ( input.LA(1) ) 
            {
            case FLOAT:
            	{
                alt8 = 1;
                }
                break;
            case ID:
            	{
                alt8 = 2;
                }
                break;
            case INT:
            	{
                alt8 = 3;
                }
                break;
            case 36:
            	{
                alt8 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:131:4: f= FLOAT
                    {
                    	f=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_factor844); 
                    	 val = new ValueExpr(float.Parse(f.Text)); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:132:4: id= ID
                    {
                    	id=(IToken)Match(input,ID,FOLLOW_ID_in_factor853); 
                    	 val = new NodeStateExpr(id.Text); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:133:4: i= INT
                    {
                    	i=(IToken)Match(input,INT,FOLLOW_INT_in_factor865); 
                    	 val = new ValueExpr(float.Parse(i.Text)); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\otavio\\Desktop\\Fruki\\San2Markov\\SAN.g:134:4: '(' intern= expr ')'
                    {
                    	Match(input,36,FOLLOW_36_in_factor874); 
                    	PushFollow(FOLLOW_expr_in_factor878);
                    	intern = expr();
                    	state.followingStackPointer--;

                    	Match(input,37,FOLLOW_37_in_factor880); 
                    	 val=intern; 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return val;
    }
    // $ANTLR end "factor"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_automonus_in_start559 = new BitSet(new ulong[]{0x0000000000410000UL});
    public static readonly BitSet FOLLOW_eventrl_in_start568 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_16_in_automonus587 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_automonus591 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_automonus599 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_automonus604 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_automonus606 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_automonus610 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_19_in_automonus613 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FLOAT_in_automonus617 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_automonus622 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_automonus626 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_automonus628 = new BitSet(new ulong[]{0x0000000000200020UL});
    public static readonly BitSet FOLLOW_21_in_automonus637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_22_in_eventrl651 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_eventrl655 = new BitSet(new ulong[]{0x0000000001800000UL});
    public static readonly BitSet FOLLOW_set_in_eventrl659 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_eventrl667 = new BitSet(new ulong[]{0x00000010000000B0UL});
    public static readonly BitSet FOLLOW_expr_in_eventrl671 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_eventrl673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathexpr_in_expr697 = new BitSet(new ulong[]{0x00000003FC000002UL});
    public static readonly BitSet FOLLOW_set_in_expr708 = new BitSet(new ulong[]{0x00000010000000B0UL});
    public static readonly BitSet FOLLOW_expr_in_expr728 = new BitSet(new ulong[]{0x00000003FC000002UL});
    public static readonly BitSet FOLLOW_term_in_mathexpr753 = new BitSet(new ulong[]{0x0000000400040002UL});
    public static readonly BitSet FOLLOW_set_in_mathexpr764 = new BitSet(new ulong[]{0x00000010000000B0UL});
    public static readonly BitSet FOLLOW_term_in_mathexpr774 = new BitSet(new ulong[]{0x0000000400040002UL});
    public static readonly BitSet FOLLOW_factor_in_term799 = new BitSet(new ulong[]{0x0000000800080002UL});
    public static readonly BitSet FOLLOW_set_in_term808 = new BitSet(new ulong[]{0x00000010000000B0UL});
    public static readonly BitSet FOLLOW_factor_in_term816 = new BitSet(new ulong[]{0x0000000800080002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_factor844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_factor853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_factor865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_factor874 = new BitSet(new ulong[]{0x00000010000000B0UL});
    public static readonly BitSet FOLLOW_expr_in_factor878 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_factor880 = new BitSet(new ulong[]{0x0000000000000002UL});

}
