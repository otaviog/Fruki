grammar SAN;

options {
language = CSharp;
}

@parser::header 
{
using San2Markov;
}

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;


INT :	'0'..'9'+
    ;

FLOAT
    :   ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
    |   '.' ('0'..'9')+ EXPONENT?
    |   ('0'..'9')+ EXPONENT
    ;

COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
    ;

fragment
EXPONENT : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

fragment
HEX_DIGIT : ('0'..'9'|'a'..'f'|'A'..'F') ;

fragment
ESC_SEQ
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    |   UNICODE_ESC
    |   OCTAL_ESC
    ;

fragment
OCTAL_ESC
    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7')
    ;

ROOT 	:	 '@' ;

fragment
UNICODE_ESC
    :   '\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
    ;

start 	[SAN san] :	(aut=automonus { san.AddAutonomus(aut); })+ (ev=eventrl { san.AddEvent(ev); } )+ ;
	
automonus returns [Autonomus aut] : 'autonomus' name=ID 
	{ 
		aut = new Autonomus(name.Text); 
	} 
	'{' (fromName=INT '-' ev=ID ('*' tax=FLOAT)?  '-' toName=INT ';'
	{		
		float ratio = (tax != null) ? float.Parse(tax.Text, System.Globalization.CultureInfo.InvariantCulture) : 1.0f;
		aut.AddEdge(ev.Text, Int32.Parse(fromName.Text), Int32.Parse(toName.Text), 
			ratio);	
		tax = null;	

	}
	)+ '}'
	;
	
eventrl	returns [Event ev]: 'event' name=ID opt=('syn' | 'loc') ':=' ex=expr ';' 
	{
		Event.EventType tp = (opt.Text == "syn") ? Event.EventType.SYN : Event.EventType.LOC;
		ev = new Event(name.Text, tp, ex);
	}
	;
	
expr   returns [Expr rexpr]
	: left=mathexpr 
	{
		rexpr = left;
	}	
	(s=('<'|'>'|'='|'<='|'>='|'!>'|'and'|'or') right=expr
	{		
		rexpr = new LogicExpr(s.Text, left, right);
		left = rexpr;
	}
	)*
	;

mathexpr returns [Expr arit] 
	: left=term 
	{ 
		arit = left;	
	} 
	(s=('+' | '-') right=term 
	{
		arit = new AritExpr(s.Text[0], left, right);
		left = arit;		
	}
	)*
	;

term returns [Expr arit]
	: left=factor
	{
		arit = left;
	}
	(s=('*'|'/') right=factor
	{
		arit = new AritExpr(s.Text[0], left, right);
		left = arit;
	}
	)*
	;	
		
factor returns [Expr val]	
	: f=FLOAT { val = new ValueExpr(float.Parse(f.Text)); }
	| id=ID   { val = new NodeStateExpr(id.Text); } 
	| i=INT	  { val = new ValueExpr(float.Parse(i.Text)); }
	| '(' intern=expr ')' 	{ val=intern; }
	;
