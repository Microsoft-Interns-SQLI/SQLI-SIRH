import { Component, OnDestroy, OnInit, Output } from '@angular/core';
import { Subscription } from 'rxjs';
import { mdm } from './mdm.config';
import { MdmService } from '../services/mdm.service';

@Component({
  selector: 'app-mdm-panel',
  templateUrl: './mdm-panel.component.html',
  styleUrls: ['./mdm-panel.component.css'],
})
export class MdmPanelComponent implements OnInit, OnDestroy {
  mdm: any = mdm;
  mdmKeys: any = Object.keys(this.mdm);
  selectedItem: any;
  mdmData: any;
  subscription?: Subscription;
  addSubscription?: Subscription;
  deleteSubscription?: Subscription;
  constructor(private mdmService: MdmService) {}
  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
    this.addSubscription?.unsubscribe();
    this.deleteSubscription?.unsubscribe();
  }

  ngOnInit(): void {}

  onChange(item: any) {
    this.selectedItem = item.target.value;
    if (this.subscription) this.subscription.unsubscribe();
    this.subscription = this.mdmService
      .getAll(this.selectedItem)
      .subscribe((res) => {
        this.mdmData = res;
      });
  }

  handleAdd(item: any) {
    if (this.addSubscription) this.addSubscription.unsubscribe();
    this.addSubscription = this.mdmService
      .add(this.selectedItem, item)
      .subscribe((res) => this.mdmData.push(res));
  }

  handleDelete(itemId: any) {
    if (this.deleteSubscription) this.deleteSubscription.unsubscribe();
    this.deleteSubscription = this.mdmService
      .delete(this.selectedItem, itemId)
      .subscribe(() => {
        this.mdmData = this.mdmData?.filter((n: any) => n.id !== itemId);
      });
  }
}
