import { Component, OnInit } from '@angular/core';
import { EpochService } from 'src/app/services/epoch.service';
import { first } from 'rxjs/operators';
import { EpochDashboardDto } from 'src/app/dto/epoch/epoch-dashboard-dto';

@Component({
  selector: 'app-epoch-dashboard',
  templateUrl: './epoch-dashboard.component.html',
  styleUrls: ['./epoch-dashboard.component.scss']
})
export class EpochDashboardComponent implements OnInit {

  private epoches: Array<EpochDashboardDto>;

  constructor(private epochService: EpochService) { }

  ngOnInit() {
    this.epochService.getEpoches().pipe(first()).subscribe(
      data => {
        this.epoches = data;
      }
    )
  }

}
