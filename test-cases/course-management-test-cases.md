# Course Management Test Cases

## COURSE-001: Add valid course

**Steps:**
1. Navigate to Courses page  
2. Click Add Course  
3. Enter valid data (name, credits, semester)  
4. Submit  

**Expected Result:**
Course is successfully added and displayed in list  

---

## COURSE-002: Reject empty course name

**Steps:**
1. Click Add Course  
2. Leave course name blank  
3. Submit  

**Expected Result:**
Validation error should be shown  

---

## COURSE-003: Edit course

**Steps:**
1. Select existing course  
2. Click Edit  
3. Modify credits  
4. Save  

**Expected Result:**
Updated values are reflected  

---

## COURSE-004: Delete course

**Steps:**
1. Select course  
2. Click Delete  
3. Confirm  

**Expected Result:**
Course is removed from list  

---

## COURSE-005: Invalid credit value

**Steps:**
1. Add course with negative credits  

**Expected Result:**
System should reject invalid input  