import { Component, OnInit } from '@angular/core';
import { SugarLevelService } from '../shared/api/sugar-level.service';
import { SugarLevel } from '../shared/models/SugarLevel';

@Component({
  selector: 'app-sugarlevel-list',
  templateUrl: './sugarlevel-list.component.html',
  styleUrls: ['./sugarlevel-list.component.css']
})
export class SugarlevelListComponent implements OnInit {

  constructor(private sugarLevelService: SugarLevelService) { }

  sugarLevels: Array<SugarLevel>;

  ngOnInit() {
    alert('getting all');
    this.sugarLevelService.getAll().subscribe(data => {
      this.sugarLevels = data;
    });
  }

}
