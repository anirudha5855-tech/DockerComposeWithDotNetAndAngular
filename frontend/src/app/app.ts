import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StudentService } from './StudentService';

@Component({
  // imports: [RouterOutlet],
  selector: 'app-root',
  styleUrl: './app.css',
  templateUrl: './app.html',
  providers:[StudentService]
})
export class App {

  students:any=[];
  constructor(private sr:StudentService){
    sr.getStudents().subscribe((e:any)=>{
      console.log(e);
      this.students=e;
    })
  }

}
