SELECT DATETIME(l."TIMESTAMP", 'unixepoch') as time, WORD_ID, w.WORD, l.REPETITION, l.STATUS, l.LOCAL_DATE,
	DATETIME(w.TS_LAST_DISPLAYED, 'unixepoch') as last_rep , 
	DATETIME(w.TS_LAST_DISPLAYED + w.OFFSET_TO_NEXT_DISPLAY, 'unixepoch') as next_rep, 
	w.COUNT_REPEATED as cnt_rep
FROM LOG l
JOIN WORD w on W.ID=l.WORD_ID 
where l.WORD_ID = 11458
limit 100;



select iq.*, w.WORD  from (
	SELECT WORD_ID, COUNT() 
	FROM LOG l
	group by WORD_ID
	ORDER by COUNT() DESC
	limit 100) iq
JOIN WORD w on W.ID=iq.WORD_ID 
--11458	18	derisive