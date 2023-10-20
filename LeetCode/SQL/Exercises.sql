-- 595. Big Countries
SELECT name, population, area   
FROM World
Where area >= 3000000 or population >= 25000000

-- 1148. Article Views I
SELECT DISTINCT author_id as id  
FROM Views
Where author_id = viewer_id
ORDER by author_id

-- 1683. Invalid Tweets
SELECT tweet_id 
FROM Tweets
Where LENGTH(content) > 15

-- 1378. Replace Employee ID With The Unique Identifier
SELECT EmployeeUNI.unique_id, Employees.name
FROM Employees
LEFT JOIN EmployeeUNI ON Employees.id = EmployeeUNI.id

-- 1068. Product Sales Analysis I
SELECT p.product_name, s.year, s.price 
FROM Sales s
INNER JOIN Product p ON p.product_id = s.product_id ;

-- 1581. Customer Who Visited but Did Not Make Any Transactions
SELECT v.customer_id, COUNT(v.customer_id) AS count_no_trans
FROM Visits v
LEFT JOIN Transactions t ON v.visit_id = t.visit_id
WHERE t.transaction_id IS NULL
GROUP BY v.customer_id

-- 197. Rising Temperature
SELECT w1.id
FROM Weather w1, Weather w2
Where DATEDIFF(w1.recordDate, w2.recordDate) = 1 AND w1.temperature > w2.temperature;

-- 1661. Average Time of Process per Machine
select a1.machine_id, round(avg(a2.timestamp-a1.timestamp), 3) as processing_time 
from Activity a1
join Activity a2 
on a1.machine_id=a2.machine_id and a1.process_id=a2.process_id
and a1.activity_type='start' and a2.activity_type='end'
group by a1.machine_id